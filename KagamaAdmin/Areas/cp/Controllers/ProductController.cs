using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Product;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ProductController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public ProductController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Product> model = _repository.GetProducts().ToList();

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

            ViewBag.Eur = _repository.GetEurCourse("eur").Course;

            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model, IFormFile pdf)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (pdf != null)
                    {
                        if (pdf.ContentType != "application/pdf")
                        {
                            ModelState.AddModelError("PDf", "Загрузите pdf файл");
                            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");
                            return View(model);
                        }

                        var path = "/uploads/" + Guid.NewGuid() + pdf.FileName.ToLower();
                        path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            pdf.CopyTo(stream);
                        }

                        model.Pdf = path;
                    }
                    _repository.ProductCreate(model);
                    return RedirectToAction("Index", "Product", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Product model = _repository.GetProduct(id);

            if (model == null)
                return NotFound();

            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Product model, IFormFile pdf)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (pdf != null)
                    {

                        if (pdf.ContentType != "application/pdf")
                        {
                            ModelState.AddModelError("PDf", "Загрузите pdf файл");
                            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");
                            return View(model);
                        }

                        string fullPath = _appEnvironment.WebRootPath + model.Pdf;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + pdf.FileName.ToLower();
                        path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            pdf.CopyTo(stream);
                        }

                        model.Pdf = path;
                    }

                    _repository.ProductEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.ProductCategories = new SelectList(_repository.ProductCategories(), "Id", "Title");

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Product model = _repository.GetProduct(id);

            if (model == null)
                return NotFound();

            if (model.Img1 != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.Img1;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (model.Img2 != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.Img2;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (model.Img3 != null)
            {
                string fullPath = _appEnvironment.WebRootPath + model.Img3;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.ProductBuyDeleteAll(model.Id);

            _repository.ProductDelete(model);

            return RedirectToAction("Index", "Product", new { area = "cp" });
        }

        public IActionResult Category() => View();

        [HttpPost]
        public IActionResult Category(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ProductCategoryCreate(model);
                    return RedirectToAction("Category", "Product", new { area = "cp" });
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
            ProductCategory model = _repository.GetProductCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ProductCategoryEdit(model);
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
            ProductCategory model = _repository.GetProductCategory(id);

            if (model == null)
                return NotFound();

            _repository.ProductCategoryDelete(model);

            return RedirectToAction("Category", "Product", new { area = "cp" });
        }

        public IActionResult Image(int id)
        {
            Product model = _repository.GetProduct(id);

            if (model == null)
                return NotFound();

            ImageView imageView = new ImageView
            {
                Id = model.Id,
                Title = model.Title,
                Img1 = model.Img1,
                Img2 = model.Img2,
                Img3 = model.Img3
            };

            return View(imageView);
        }

        [HttpPost]
        public IActionResult Image(IFormFile img1, IFormFile img2, IFormFile img3, ImageView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (img1 != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Img1;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + img1.FileName.ToLower();
                        path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            img1.CopyTo(stream);
                        }

                        model.Img1 = path;
                    }

                    if (img2 != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Img2;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + img2.FileName.ToLower();
                        path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            img2.CopyTo(stream);
                        }

                        model.Img2 = path;
                    }

                    if (img3 != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Img3;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + img3.FileName.ToLower();
                        path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            img3.CopyTo(stream);
                        }

                        model.Img3 = path;
                    }

                    _repository.ProductImage(model.Id, model.Img1, model.Img2, model.Img3);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult Buy(int id)
        {
            Product model = _repository.GetProduct(id);

            if (model == null)
                return NotFound();

            ProductBuyView productBuyView = new ProductBuyView
            {
                Id = model.Id,
                Title = model.Title,
            };

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");

            return View(productBuyView);
        }

        [HttpPost]
        public IActionResult Buy(ProductBuyView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ProductBuy(model.ProductId, model.Id);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");
            return View(model);
        }

        public IActionResult Seo(int id)
        {
            Product model = _repository.GetProduct(id);

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
                    _repository.ProductSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(seoView);
        }

        public IActionResult ProductBuyDelete(int thisId, int productId)
        {
            ProductBuy model = _repository.GetProductBuy(thisId, productId);

            if (model == null)
                return NotFound();

            _repository.ProductBuyDelete(model);

            return RedirectToAction("Buy", "Product", new { area = "cp", id = thisId });
        }

        [HttpPost]
        public void UpdateEur(decimal eur) => _repository.UpdateEur(eur);
    }
}