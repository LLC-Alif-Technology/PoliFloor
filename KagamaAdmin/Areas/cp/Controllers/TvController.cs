using KagamaAdmin.Areas.cp.ViewModels.Tv;
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
    public class TvController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public TvController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Tv> model = _repository.GetTvs().ToList();

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
        public IActionResult Create(IFormFile icon, IFormFile banner, TvView model)
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

                    if (banner != null)
                    {
                        var path = "/uploads/" + Guid.NewGuid() + banner.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            banner.CopyTo(stream);
                        }

                        model.Banner = path;
                    }

                    _repository.TvCreate(model.Icon, model.Banner, model.Caption, model.Title, model.SubTitle, model.TitleH1, model.Alias, model.Description1, model.IsTv);
                    return RedirectToAction("Index", "Tv", new { area = "cp" });
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
            Tv tv = _repository.GetTv(id);

            if (tv == null)
                return NotFound();

            TvView model = new TvView
            {
                Id = id,
                Icon = tv.Icon,
                Banner = tv.Banner,
                Caption = tv.Caption,
                Title = tv.Title,
                SubTitle = tv.SubTitle,
                TitleH1 = tv.TitleH1,
                Alias = tv.Alias,
                Description1 = tv.Description1,
                IsTv = tv.IsTv
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(IFormFile icon, IFormFile banner, TvView model)
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
                    if (banner != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Banner;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + banner.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            banner.CopyTo(stream);
                        }

                        model.Banner = path;
                    }
                    _repository.TvEdit(model.Id, model.Icon, model.Banner, model.Caption, model.Title, model.SubTitle, model.TitleH1, model.Alias, model.Description1, model.IsTv);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }

        public IActionResult Album(int id)
        {
            Tv tv = _repository.GetTv(id);

            if (tv == null)
                return NotFound();

            AlbumView albumView = new AlbumView
            {
                Id = tv.Id,
                Title = tv.Title,
                AlbumId = tv.AlbumId,
                TitleAlbum = tv.TitleAlbum,
                LinkAlbum = tv.LinkAlbum,
                Description2 = tv.Description2
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
                    _repository.TvAlbum(albumView.Id, albumView.TitleAlbum, albumView.AlbumId, albumView.LinkAlbum, albumView.Description2);
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
            Tv tv = _repository.GetTv(id);

            if (tv == null)
                return NotFound();

            VideoView videoView = new VideoView
            {
                Id = tv.Id,
                Title = tv.Title,
                TitleVideo = tv.TitleVideo,
                LinkVideo = tv.LinkVideo,
                Description3 = tv.Description3,
                PreviewVideo = tv.PreviewVideo
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

                    _repository.TvVideo(videoView.Id, videoView.TitleVideo, videoView.LinkVideo,
                        videoView.PreviewVideo, videoView.Description3);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(videoView);
        }

        public IActionResult Seo(int id)
        {
            Tv tv = _repository.GetTv(id);

            if (tv == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = tv.Id,
                Title = tv.Title,
                SeoTitle = tv.SeoTitle,
                SeoKeywords = tv.SeoKeywords,
                SeoDescription = tv.SeoDescription
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
                    _repository.TvSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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
            Tv tv = _repository.GetTv(id);

            if (tv == null)
                return NotFound();

            if (tv.Banner != null)
            {
                string fullPath = _appEnvironment.WebRootPath + tv.Banner;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (tv.Icon != null)
            {
                string fullPath = _appEnvironment.WebRootPath + tv.Icon;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            
            if (tv.PreviewVideo != null)
            {
                string fullPath = _appEnvironment.WebRootPath + tv.PreviewVideo;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.TvDelete(tv);

            return RedirectToAction("Index", "Tv", new { area = "cp" });
        }
    }
}