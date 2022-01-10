using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Article;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ArticleController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public ArticleController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Article> model = _repository.GetArticles().ToList();

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
                    case "articles":
                        model = model.Where(x => x.IsNews == false);
                        break;
                    case "news":
                        model = model.Where(x => x.IsNews == true);
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
        public IActionResult Category(ArticleCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ArticleCategoryCreate(model);
                    return RedirectToAction("Category", "Article", new { area = "cp" });
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
            ArticleCategory model = _repository.GetArticleCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(ArticleCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ArticleCategoryEdit(model);
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
            ArticleCategory model = _repository.GetArticleCategory(id);

            if (model == null)
                return NotFound();

            _repository.ArticleCategoryDelete(model);

            return RedirectToAction("Category", "Article", new { area = "cp" });
        }

        public IActionResult Create()
        {
            ViewBag.ArticleCategories = new SelectList(_repository.ArticleCategories(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Article model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.CreationDate = DateTime.Now;
                    _repository.ArticleCreate(model);
                    return RedirectToAction("Index", "Article", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.ArticleCategories = new SelectList(_repository.ArticleCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Article model = _repository.GetArticle(id);

            if (model == null)
                return NotFound();

            ViewBag.ArticleCategories = new SelectList(_repository.ArticleCategories(), "Id", "Title");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Article model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ArticleEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.ArticleCategories = new SelectList(_repository.ArticleCategories(), "Id", "Title");

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Article model = _repository.GetArticle(id);

            if (model == null)
                return NotFound();

            if (model.Img != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.Img;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (model.ImgOpenPage != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.ImgOpenPage;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            _repository.ArticleDelete(model);

            return RedirectToAction("Index", "Article", new { area = "cp" });
        }

        public IActionResult Image(int id)
        {
            Article model = _repository.GetArticle(id);

            if (model == null)
                return NotFound();

            ImageView imageView = new ImageView
            {
                Id = model.Id,
                Title = model.Title,
                Img = model.Img,
                ImgOpenPage = model.ImgOpenPage
            };

            return View(imageView);
        }

        [HttpPost]
        public IActionResult Image(IFormFile img, IFormFile imgOpenPage, ImageView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (img != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Img;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + img.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            img.CopyTo(stream);
                        }

                        model.Img = path;
                    }

                    if (imgOpenPage != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.ImgOpenPage;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + imgOpenPage.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            imgOpenPage.CopyTo(stream);
                        }

                        model.ImgOpenPage = path;
                    }

                    _repository.ArticleImage(model.Id, model.Img, model.ImgOpenPage);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult Seo(int id)
        {
            Article model = _repository.GetArticle(id);

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
                    _repository.ArticleSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(seoView);
        }
    }
}