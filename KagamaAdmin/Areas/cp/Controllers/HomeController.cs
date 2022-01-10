using KagamaAdmin.Areas.cp.ViewModels.Page;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class HomeController : Controller
    {
        private IKagamaRepository _repository;
        public HomeController(IKagamaRepository repository)
        {
            _repository = repository;
        }

        [Route("/cp")]
        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Page> model = _repository.GetPages().ToList();

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
        public IActionResult Create(Page model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.PageCreate(model);
                    return RedirectToAction("Index", "Home", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Page model = _repository.GetPage(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Page model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.PageEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Page model = _repository.GetPage(id);

            if (model == null)
                return NotFound();


            _repository.PageDelete(model);

            return RedirectToAction("Index", "Home", new { area = "cp" });
        }

        public IActionResult Seo(int id)
        {
            Page model = _repository.GetPage(id);

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
                    _repository.PageSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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
