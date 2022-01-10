using KagamaAdmin.Areas.cp.ViewModels.Floor;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class FloorController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public FloorController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Floor> model = _repository.GetFloors().ToList();

            model = model.OrderByDescending(x => x.Id);

            if (!string.IsNullOrEmpty(sortOrder))
            {
                switch (sortOrder)
                {
                    case "nameasc":
                        model = model.OrderByDescending(s => s.Title);
                        break;
                    case "namedesc":
                        model = model.OrderBy(s => s.Title);
                        break;
                }
            }

            if (!string.IsNullOrEmpty(search))
            {
                model = model.OrderByDescending(x => x.Id)
                    .Where(p => EF.Functions.Like(p.Title, "%" + search + "%"));
            }

            return View(model);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(IFormFile icon, FloorView floorView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon != null)
                    {
                        var path = "/uploads/" + Guid.NewGuid() + icon.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            icon.CopyTo(stream);
                        }

                        floorView.Icon = path;
                    }

                    _repository.FloorCreate(floorView.Title, floorView.TitleH1, floorView.Alias, floorView.Description1, floorView.Icon);
                    return RedirectToAction("Index", "Floor", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            Floor floor = _repository.GetFloor(id);

            if (floor == null)
                return NotFound();

            FloorView model = new FloorView
            {
                Id = id,
                Title = floor.Title,
                TitleH1 = floor.TitleH1,
                Alias = floor.Alias,
                Description1 = floor.Description1,
                Icon = floor.Icon
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(IFormFile icon, FloorView floorView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + floorView.Icon;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + icon.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            icon.CopyTo(stream);
                        }

                        floorView.Icon = path;
                    }
                    _repository.FloorEdit(floorView.Id, floorView.Title, floorView.TitleH1, floorView.Alias, floorView.Description1, floorView.Icon);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(floorView);
        }

        public IActionResult Album(int id)
        {
            Floor floor = _repository.GetFloor(id);

            if (floor == null)
                return NotFound();

            AlbumView albumView = new AlbumView
            {
                Id = floor.Id,
                Title = floor.Title,
                AlbumId = floor.AlbumId,
                TitleAlbum = floor.TitleAlbum,
                LinkAlbum = floor.LinkAlbum,
                Description2 = floor.Description2
            };

            ViewBag.AlbumsList = new SelectList(_repository.GalleryAlbums(), "Id", "Title");
            return View(albumView);
        }

        [HttpPost]
        public IActionResult Album(AlbumView albumView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.FloorAlbum(albumView.Id, albumView.TitleAlbum, albumView.AlbumId, albumView.LinkAlbum, albumView.Description2);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.AlbumsList = new SelectList(_repository.GalleryAlbums(), "Id", "Title");
            return View(albumView);
        }

        public IActionResult Material(int id)
        {
            Floor floor = _repository.GetFloor(id);

            if (floor == null)
                return NotFound();

            ProductView productView = new ProductView
            {
                Id = floor.Id,
                Title = floor.Title,
                TitleProducts = floor.TitleProducts,
                Description3 = floor.Description3
            };

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");
            return View(productView);
        }

        public void AddProductForFloor(int floorId, int prodId)
        {
            _repository.AddProductForFloor(floorId, prodId);
        }

        [HttpPost]
        public IActionResult Material(ProductView productView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.FloorProduct(productView.Id, productView.TitleProducts, productView.Description3);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");
            return View(productView);
        }

        public IActionResult FloorProductDelete(int productId, int floorId)
        {
            FloorProduct model = _repository.GetFloorProduct(productId, floorId);

            if (model == null)
                return NotFound();

            _repository.FloorProductDelete(model);

            return RedirectToAction("Material", "Floor", new { area = "cp", id = floorId });
        }

        public IActionResult Question(int id)
        {
            Floor floor = _repository.GetFloor(id);

            if (floor == null)
                return NotFound();

            QuestionView questionView = new QuestionView
            {
                Id = floor.Id,
                Title = floor.Title,
                TitleQuestion = floor.TitleQuestion,
                Description4 = floor.Description4
            };

            ViewBag.Questions = new SelectList(_repository.GetArticles().Where(x => x.IsNews == false), "Id", "Title");

            return View(questionView);
        }

        public void AddQuestionForFloor(int floorId, int artId)
        {
            _repository.AddQuestionForFloor(floorId, artId);
        }

        [HttpPost]
        public IActionResult Question(QuestionView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.FloorQuestion(model.Id, model.TitleQuestion, model.Description4);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Questions = new SelectList(_repository.GetArticles().Where(x => x.IsNews == false), "Id", "Title");
            return View(model);
        }

        public IActionResult FloorQuestionDelete(int artId, int floorId)
        {
            FloorQuestion model = _repository.GetFloorQuestion(artId, floorId);

            if (model == null)
                return NotFound();

            _repository.FloorQuestionDelete(model);

            return RedirectToAction("Question", "Floor", new { area = "cp", id = floorId });
        }

        public IActionResult Seo(int id)
        {
            Floor floor = _repository.GetFloor(id);

            if (floor == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = floor.Id,
                Title = floor.Title,
                SeoTitle = floor.SeoTitle,
                SeoKeywords = floor.SeoKeywords,
                SeoDescription = floor.SeoDescription
            };

            return View(seoView);
        }

        [HttpPost]
        public IActionResult Seo(SeoView seoView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.FloorSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(seoView);
        }

        public IActionResult Delete(int id)
        {
            Floor model = _repository.GetFloor(id);

            if (model == null)
                return NotFound();

            if (model.Icon != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.Icon;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.FloorDeleteAllMaterials(model.Id);
            _repository.FloorDeleteAllQuestions(model.Id);
            _repository.FloorDelete(model);

            return RedirectToAction("Index", "Floor", new { area = "cp" });
        }
    }
}