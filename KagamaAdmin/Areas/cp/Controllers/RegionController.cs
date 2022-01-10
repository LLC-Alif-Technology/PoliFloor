using KagamaAdmin.Areas.cp.ViewModels.Region;
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
    public class RegionController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public RegionController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Region> model = _repository.GetRegions().ToList();

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

        public IActionResult Category() => View();

        [HttpPost]
        public IActionResult Category(RegionCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.RegionCategoryCreate(model);
                    return RedirectToAction("Category", "Region", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult CategoryEdit(int id)
        {
            RegionCategory model = _repository.GetRegionCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(RegionCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.RegionCategoryEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult CategoryDelete(int id)
        {
            RegionCategory model = _repository.GetRegionCategory(id);

            if (model == null)
                return NotFound();

            _repository.RegionCategoryDelete(model);

            return RedirectToAction("Category", "Region", new { area = "cp" });
        }

        public IActionResult Create()
        {
            ViewBag.RegionCategories = new SelectList(_repository.RegionCategories(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Region model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.RegionCreate(model);
                    return RedirectToAction("Index", "Region", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.RegionCategories = new SelectList(_repository.RegionCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Region model = _repository.GetRegion(id);

            if (model == null)
                return NotFound();

            ViewBag.RegionCategories = new SelectList(_repository.RegionCategories(), "Id", "Title");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Region model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.RegionEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.RegionCategories = new SelectList(_repository.RegionCategories(), "Id", "Title");

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Region model = _repository.GetRegion(id);

            if (model == null)
                return NotFound();

            if (model.PreviewVideo != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.PreviewVideo;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.RegionDeleteAllMaterials(id);
            _repository.RegionDelete(model);

            return RedirectToAction("Index", "Region", new { area = "cp" });
        }

        public IActionResult Seo(int id)
        {
            Region model = _repository.GetRegion(id);

            if (model == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = model.Id,
                Title = model.Title,
                SeoTitle = model.SeoTitle,
                SeoKeywords = model.SeoKeywords,
                SeoDescription = model.SeoDescription
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
                    _repository.RegionSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(seoView);
        }

        public IActionResult Album(int id)
        {
            Region region = _repository.GetRegion(id);

            if (region == null)
                return NotFound();

            AlbumView albumView = new AlbumView
            {
                Id = region.Id,
                Title = region.Title,
                AlbumId = region.AlbumId,
                TitleAlbum = region.TitleAlbum,
                LinkAlbum = region.LinkAlbum,
                Description2 = region.Description2
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
                    _repository.RegionAlbum(albumView.Id, albumView.TitleAlbum, albumView.AlbumId, albumView.LinkAlbum, albumView.Description2);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.AlbumsList = new SelectList(_repository.GalleryAlbums(), "Id", "Title");
            return View(albumView);
        }

        public IActionResult Video(int id)
        {
            Region region = _repository.GetRegion(id);

            if (region == null)
                return NotFound();

            VideoView videoView = new VideoView
            {
                Id = region.Id,
                Title = region.Title,
                TitleVideo = region.TitleVideo,
                LinkVideo = region.LinkVideo,
                Description3 = region.Description3,
                PreviewVideo = region.PreviewVideo
            };

            return View(videoView);
        }

        [HttpPost]
        public IActionResult Video(IFormFile previewVideo, VideoView videoView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (previewVideo != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + videoView.PreviewVideo;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + previewVideo.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            previewVideo.CopyTo(stream);
                        }

                        videoView.PreviewVideo = path;
                    }

                    _repository.RegionVideo(videoView.Id, videoView.TitleVideo, videoView.LinkVideo,
                        videoView.PreviewVideo, videoView.Description3);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(videoView);
        }

        public IActionResult Material(int id)
        {
            Region region = _repository.GetRegion(id);

            if (region == null)
                return NotFound();

            ProductView productView = new ProductView
            {
                Id = region.Id,
                Title = region.Title,
                TitleProducts = region.TitleProducts,
                Description4 = region.Description4
            };

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");

            return View(productView);
        }

        public void AddProductForRegion(int regionId, int prodId)
        {
            _repository.AddProductForRegion(regionId, prodId);
        }

        [HttpPost]
        public IActionResult Material(ProductView productView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.RegionProduct(productView.Id, productView.TitleProducts, productView.Description4);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(productView);
        }

        public IActionResult RegionProductDelete(int productId, int regionId)
        {
            RegionProduct model = _repository.GetRegionProduct(productId, regionId);

            if (model == null)
                return NotFound();

            _repository.RegionProductDelete(model);

            return RedirectToAction("Material", "Region", new { area = "cp", id = regionId });
        }
    }
}