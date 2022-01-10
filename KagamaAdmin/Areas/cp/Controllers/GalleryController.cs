using KagamaAdmin.Areas.cp.ViewModels;
using KagamaAdmin.Areas.cp.ViewModels.Gallery;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class GalleryController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public GalleryController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            GalleryView model = new GalleryView
            {
                GalleryAlbums = _repository.GalleryAlbums()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(GalleryView model, IFormFile icon)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon == null)
                        throw new Exception("Загрузите изображение!");

                    var path = "/uploads/" + Guid.NewGuid() + icon.FileName.ToLower();
                    using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        icon.CopyTo(stream);
                    }

                    model.Icon = path;

                    GalleryItem galleryItem = new GalleryItem
                    {
                        Title = model.Title,
                        Icon = model.Icon
                    };

                    int itemId = _repository.GalleryItemCreate(galleryItem);

                    if (model.MyCheck != null)
                    {
                        foreach (var check in model.MyCheck)
                        {
                            var album = _repository.GetGalleryAlbum(check);

                            GalleryRelation galleryRelation = new GalleryRelation
                            {
                                GalleryItemId = itemId,
                                GalleryAlbumId = album.Id,
                                GalleryCategoryId = album.GalleryCategoryId
                            };

                            _repository.GalleryRelationCreate(galleryRelation);
                        }
                    }

                    return RedirectToAction("Index", "Gallery", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            model.GalleryAlbums = _repository.GalleryAlbums();
            return View(model);
        }

        [Route("cp/gallery/itemlist")]
        [Route("cp/gallery/itemlist/{page}")]
        public IActionResult ItemList(int page = 1)
        {
            GalleryItemView galleryItemView = new GalleryItemView
            {
                GalleryItems = new PagedList<GalleryItem>(_repository.GalleryItems(), page, 30)
            };

            return View(galleryItemView);
        }

        [Route("cp/gallery/itemdelete/{id}")]
        [Route("cp/gallery/itemdelete/{id}/{page}")]
        public IActionResult ItemDelete(int id, int? page)
        {
            GalleryItem model = _repository.GetGalleryItem(id);

            if (model == null)
                return RedirectToAction("ItemList", "Gallery", new { area = "cp", page = page });

            var galleryRelations = _repository.GalleryRelations(id);

            if (galleryRelations != null)
                _repository.GalleryRelationDelete(galleryRelations);

            string fullPath = _appEnvironment.WebRootPath + model.Icon;

            if (System.IO.File.Exists(fullPath))
                System.IO.File.Delete(fullPath);

            _repository.GalleryItemDelete(model);

            return RedirectToAction("ItemList", "Gallery", new { area = "cp", page = page });
        }

        [Route("cp/gallery/itemedit/{id}")]
        [Route("cp/gallery/itemedit/{id}/{page}")]
        public IActionResult ItemEdit(int id, int? page)
        {
            GalleryItem galleryItem = _repository.GetGalleryItem(id);

            if (galleryItem == null)
                return NotFound();

            GalleryView model = new GalleryView
            {
                GalleryAlbums = _repository.GalleryAlbums(),
                Title = galleryItem.Title,
                Icon = galleryItem.Icon,
                MyCheck = _repository.GetGalleryRelations(id),
                PreviousPage = page
            };

            return View(model);
        }

        [HttpPost]
        [Route("cp/gallery/itemedit/{id}")]
        [Route("cp/gallery/itemedit/{id}/{page}")]
        public IActionResult ItemEdit(GalleryView model, IFormFile icon)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Icon;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + icon.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            icon.CopyTo(stream);
                        }

                        model.Icon = path;
                    }

                    _repository.GalleryItemEdit(model.Id, model.Title, model.Icon);

                    var galleryRelations = _repository.GalleryRelations(model.Id);

                    if (galleryRelations != null)
                        _repository.GalleryRelationDelete(galleryRelations);

                    if (model.MyCheck != null)
                    {
                        foreach (var check in model.MyCheck)
                        {
                            var album = _repository.GetGalleryAlbum(check);

                            GalleryRelation galleryRelation = new GalleryRelation
                            {
                                GalleryItemId = model.Id,
                                GalleryAlbumId = album.Id,
                                GalleryCategoryId = album.GalleryCategoryId
                            };

                            _repository.GalleryRelationCreate(galleryRelation);
                        }
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            model.GalleryAlbums = _repository.GalleryAlbums();
            return View(model);
        }

        public IActionResult CategoryCreate() => View();

        [HttpPost]
        public IActionResult CategoryCreate(GalleryCategory model, IFormFile icon)
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

                        model.Icon = path;
                    }

                    _repository.GalleryCategoryCreate(model);
                    return RedirectToAction("CategoryCreate", "Gallery", new { area = "cp" });
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
            GalleryCategory model = _repository.GetGalleryCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(GalleryCategory model, IFormFile icon)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (icon != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Icon;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + icon.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            icon.CopyTo(stream);
                        }

                        model.Icon = path;
                    }
                    _repository.GalleryCategoryEdit(model);
                    return RedirectToAction("CategoryCreate", "Gallery", new { area = "cp" });
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
            GalleryCategory model = _repository.GetGalleryCategory(id);

            if (model == null)
                return NotFound();

            string fullPath = _appEnvironment.WebRootPath + model.Icon;

            if (System.IO.File.Exists(fullPath))
                System.IO.File.Delete(fullPath);

            _repository.GalleryCategoryDelete(model);

            return RedirectToAction("CategoryCreate", "Gallery", new { area = "cp" });
        }

        public IActionResult AlbumCreate()
        {
            ViewBag.Categories = new SelectList(_repository.GalleryCategories(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult AlbumCreate(GalleryAlbum model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.GalleryAlbumCreate(model);
                    ViewBag.Categories = new SelectList(_repository.GalleryCategories(), "Id", "Title");
                    return RedirectToAction("AlbumCreate", "Gallery", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.Categories = new SelectList(_repository.GalleryCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult AlbumEdit(int id)
        {
            GalleryAlbum model = _repository.GetGalleryAlbum(id);
            ViewBag.Categories = new SelectList(_repository.GalleryCategories(), "Id", "Title");

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult AlbumEdit(GalleryAlbum model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.GalleryAlbumEdit(model);
                    return RedirectToAction("AlbumCreate", "Gallery", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.Categories = new SelectList(_repository.GalleryCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult AlbumDelete(int id)
        {
            GalleryAlbum model = _repository.GetGalleryAlbum(id);

            if (model == null)
                return NotFound();

            _repository.GalleryAlbumDelete(model);

            return RedirectToAction("AlbumCreate", "Gallery", new { area = "cp" });
        }
    }
}