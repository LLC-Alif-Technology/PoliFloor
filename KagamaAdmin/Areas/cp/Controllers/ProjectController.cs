using KagamaAdmin.Areas.cp.ViewModels.Project;
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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ProjectController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public ProjectController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Project> model = _repository.GetProjects().ToList();

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
        public IActionResult Create(ProjectView serviceView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ProjectCreate(serviceView.Title, serviceView.Alias, serviceView.TitleH1,
                        serviceView.Square, serviceView.City, serviceView.Price);
                    return RedirectToAction("Index", "Project", new { area = "cp" });
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
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            ProjectView model = new ProjectView
            {
                Id = id,
                Title = project.Title,
                TitleH1 = project.TitleH1,
                Alias = project.Alias,
                Square = project.Square,
                City = project.City,
                Price = project.Price
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ProjectView projectView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ProjectEdit(projectView.Id, projectView.Title, projectView.TitleH1, projectView.Alias,
                        projectView.Square, projectView.City, projectView.Price);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(projectView);
        }

        public IActionResult Image(int id)
        {
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            ImageView model = new ImageView
            {
                Id = project.Id,
                Title = project.Title,
                Img = project.Img,
                Banner = project.Banner
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Image(IFormFile img, IFormFile banner, ImageView imageView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (banner != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + imageView.Banner;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + banner.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            banner.CopyTo(stream);
                        }

                        imageView.Banner = path;
                    }

                    if (img != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + imageView.Img;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + img.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            img.CopyTo(stream);
                        }

                        imageView.Img = path;
                    }

                    _repository.ProjectImageEdit(imageView.Id, imageView.Img, imageView.Banner);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(imageView);
        }

        public IActionResult Album(int id)
        {
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            AlbumView albumView = new AlbumView
            {
                Id = project.Id,
                Title = project.Title,
                AlbumId = project.AlbumId,
                TitleAlbum = project.TitleAlbum,
                LinkAlbum = project.LinkAlbum,
                Description1 = project.Description1
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
                    _repository.ProjectAlbum(albumView.Id, albumView.TitleAlbum, albumView.AlbumId, albumView.LinkAlbum, albumView.Description1);
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
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            VideoView videoView = new VideoView
            {
                Id = project.Id,
                Title = project.Title,
                TitleVideo = project.TitleVideo,
                LinkVideo = project.LinkVideo,
                Description2 =project.Description2,
                PreviewVideo = project.PreviewVideo
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

                    _repository.ProjectVideo(videoView.Id, videoView.TitleVideo, videoView.LinkVideo,
                        videoView.PreviewVideo, videoView.Description2);
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
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = project.Id,
                Title = project.Title,
                SeoTitle = project.SeoTitle,
                SeoKeywords = project.SeoKeywords,
                SeoDescription = project.SeoDescription
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
                    _repository.ProjectSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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
            Project project = _repository.GetProject(id);

            if (project == null)
                return NotFound();

            if (project.Img != null)
            {
                string fullPath = _appEnvironment.WebRootPath + project.Img;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (project.Banner != null)
            {
                string fullPath = _appEnvironment.WebRootPath + project.Banner;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (project.PreviewVideo != null)
            {
                string fullPath = _appEnvironment.WebRootPath + project.PreviewVideo;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.ProjectDelete(project);

            return RedirectToAction("Index", "Project", new { area = "cp" });
        }
    }
}