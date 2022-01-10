using KagamaAdmin.Areas.cp.ViewModels.Calc;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class CalcController : Controller
    {
        private IKagamaRepository _repository;
        public CalcController(IKagamaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CalcCategoryView model = new CalcCategoryView
            {
                CalcCategories = _repository.CalcCategories()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CalcCategoryView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CalcCategoryCreate(model.CalcCategory);
                    return RedirectToAction("Index", "Calc", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            model.CalcCategories = _repository.CalcCategories();
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CalcCategory model = _repository.GetCalcCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(CalcCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CalcCategoryEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Thick(int id)
        {
            CalcCategory model = _repository.GetCalcCategory(id);

            if (model == null)
                return NotFound();

            CalcThickView calcThickView = new CalcThickView()
            {
                Id = model.Id,
                Title = model.Title,
                CalcThicks = _repository.CalcThicks(id)
            };

            return View(calcThickView);
        }

        [HttpPost]
        public IActionResult Thick(CalcThickView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CalcThickCreate(model.Id, model.CalcThick.Mm, model.CalcThick.Comment);
                    return RedirectToAction("Thick", "Calc", new { area = "cp", id = model.Id });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            model.CalcThicks = _repository.CalcThicks(model.Id);
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteTh(int id, int thId)
        {
            CalcThick model = _repository.GetCalcThick(thId);

            if (model == null)
                return NotFound();

            _repository.CalcThickDelete(model);

            return RedirectToAction("Thick", "Calc", new { area = "cp", id = id });
        }

        [HttpGet]
        public IActionResult Product(int id)
        {
            CalcCategory model = _repository.GetCalcCategory(id);

            if (model == null)
                return NotFound();

            CalcProductView calcProductView = new CalcProductView
            {
                Id = model.Id,
                Title = model.Title,
                CalcThicks = _repository.CalcThicks(id),
                CalcProducts = _repository.CalcProducts(id)
            };

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");
            return View(calcProductView);
        }

        [HttpPost]
        public IActionResult Product(CalcProductView model)
        {
            model.CalcThicks = _repository.CalcThicks(model.Id);
            string kg = "";

            if (ModelState.IsValid)
            {
                try
                {
                    for (var i = 0; i < model.CalcThicks.Count(); i++)
                    {
                        if (i != model.CalcThicks.Count() - 1)
                            kg += model.CalcThicks.ElementAt(i).Mm + "-" + model.Kg[i] + ";";
                        else
                            kg += model.CalcThicks.ElementAt(i).Mm + "-" + model.Kg[i];
                    }

                    _repository.CalcProductCreate(model.ProductId, model.Id, model.Glossy, model.SemiMatt, model.Matt, model.Smooth, model.Grungy, kg);

                    return RedirectToAction("Product", "Calc", new { area = "cp", id = model.Id });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");
            model.CalcProducts = _repository.CalcProducts(model.Id);
            return View(model);
        }

        [HttpGet]
        public IActionResult CalcProdEdit(int id, int calcProdId)
        {
            CalcProduct model = _repository.GetCalcProduct(calcProdId);

            if (model == null)
                return NotFound();

            CalcCategory calcCategory = _repository.GetCalcCategory(id);

            CalcProductView calcProductView = new CalcProductView
            {
                Id = calcCategory.Id,
                Title = calcCategory.Title,
                CalcThicks = _repository.CalcThicks(id),
                CalcProducts = _repository.CalcProducts(id),
                Glossy = model.Glossy,
                Grungy = model.Grungy,
                Matt = model.Matt,
                SemiMatt = model.SemiMatt,
                Smooth = model.Smooth,
                ProductId = model.ProductId,
                Kg = model.Kg.Split(";"),
                ThisId = calcProdId
            };

            for (var i = 0; i < calcProductView.Kg.Length; i++)
            {
                calcProductView.Kg[i] = calcProductView.Kg[i].Substring(calcProductView.Kg[i].IndexOf('-') + 1);
            }

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");

            return View(calcProductView);
        }

        [HttpPost]
        public IActionResult CalcProdEdit(CalcProductView model)
        {
            model.CalcThicks = _repository.CalcThicks(model.Id);
            string kg = "";

            if (ModelState.IsValid)
            {
                try
                {
                    for (var i = 0; i < model.CalcThicks.Count(); i++)
                    {
                        if (i != model.CalcThicks.Count() - 1)
                        {
                            kg += model.CalcThicks.ElementAt(i).Mm + "-" + model.Kg[i] + ";";
                        }
                        else
                        {
                            kg += model.CalcThicks.ElementAt(i).Mm + "-" + model.Kg[i];
                        }
                    }

                    _repository.CalcProductEdit(model.ProductId, model.Id, model.Glossy, model.SemiMatt, model.Matt, model.Smooth, model.Grungy, kg, model.ThisId);
                    return RedirectToAction("Product", "Calc", new { area = "cp", id = model.Id });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");

            model.CalcProducts = _repository.CalcProducts(model.Id);
            return View(model);
        }

        public IActionResult CalcProdDelete(int id, int calcProdId)
        {
            CalcProduct model = _repository.GetCalcProduct(calcProdId);

            if (model == null)
                return NotFound();

            _repository.CalcProductDelete(model);

            return RedirectToAction("Product", "Calc", new { area = "cp", id = id });
        }

        public IActionResult Delete(int id)
        {
            CalcCategory model = _repository.GetCalcCategory(id);

            if (model == null)
                return NotFound();

            _repository.CalcCategoryDelete(model);

            return RedirectToAction("Index", "Calc", new { area = "cp" });
        }

        public IActionResult Seo(int id)
        {
            CalcCategory model = _repository.GetCalcCategory(id);

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
                    _repository.CalcSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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