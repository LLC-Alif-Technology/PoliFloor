using KagamaAdmin.Areas.cp.ViewModels.Video;
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
    public class VideoController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;

        public VideoController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Video> model = _repository.GetVideos().ToList();

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
        public IActionResult Category(VideoCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.VideoCategoryCreate(model);
                    return RedirectToAction("Category", "Video", new { area = "cp" });
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
            VideoCategory model = _repository.GetVideoCategory(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult CategoryEdit(VideoCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.VideoCategoryEdit(model);
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
            VideoCategory model = _repository.GetVideoCategory(id);

            if (model == null)
                return NotFound();

            _repository.VideoCategoryDelete(model);

            return RedirectToAction("Category", "Video", new { area = "cp" });
        }

        public IActionResult Create()
        {
            ViewBag.VideoCategories = new SelectList(_repository.VideoCategories(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile thumb, IFormFile banner, VideoView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (thumb != null)
                    {
                        var path = "/uploads/" + Guid.NewGuid() + thumb.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            thumb.CopyTo(stream);
                        }

                        model.Thumb = path;
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

                    _repository.VideoCreate(model.Title, model.TitleH1, model.Alias, model.Description, model.Thumb, model.Banner, model.LinkVideo, model.CategoryId);
                    return RedirectToAction("Index", "Video", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.VideoCategories = new SelectList(_repository.VideoCategories(), "Id", "Title");
            return View();
        }

        public IActionResult Edit(int id)
        {
            Video video = _repository.GetVideo(id);

            if (video == null)
                return NotFound();

            VideoView model = new VideoView
            {
                Id = id,
                Title = video.Title,
                TitleH1 = video.TitleH1,
                Alias = video.Alias,
                Description = video.Description,
                Thumb = video.Thumb,
                Banner = video.Banner,
                LinkVideo = video.LinkVideo,
                CategoryId = video.CategoryId
            };
            ViewBag.VideoCategories = new SelectList(_repository.VideoCategories(), "Id", "Title");
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(IFormFile thumb, IFormFile banner, VideoView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (thumb != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + model.Thumb;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + thumb.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            thumb.CopyTo(stream);
                        }

                        model.Thumb = path;
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
                    _repository.VideoEdit(model.Id, model.Title, model.TitleH1, model.Alias, model.Description, model.Thumb, model.Banner, model.LinkVideo, model.CategoryId);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.VideoCategories = new SelectList(_repository.VideoCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult Seo(int id)
        {
            Video video = _repository.GetVideo(id);

            if (video == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = video.Id,
                Title = video.Title,
                SeoTitle = video.SeoTitle,
                SeoKeywords = video.SeoKeywords,
                SeoDescription = video.SeoDescription
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
                    _repository.VideoSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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
            Video video = _repository.GetVideo(id);

            if (video == null)
                return NotFound();

            if (video.Banner != null)
            {
                string fullPath = _appEnvironment.WebRootPath + video.Banner;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (video.Thumb != null)
            {
                string fullPath = _appEnvironment.WebRootPath + video.Thumb;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.VideoDelete(video);

            return RedirectToAction("Index", "Video", new { area = "cp" });
        }
    }
}