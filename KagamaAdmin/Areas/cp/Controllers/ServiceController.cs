using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Service;
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
    public class ServiceController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        public ServiceController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Service> model = _repository.GetServices().ToList();

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
        public IActionResult Create(IFormFile imgServicePage, ServiceView serviceView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (imgServicePage != null)
                    {
                        var path = "/uploads/" + Guid.NewGuid() + imgServicePage.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            imgServicePage.CopyTo(stream);
                        }

                        serviceView.ImgServicePage = path;
                    }

                    _repository.ServiceCreate(serviceView.Title, serviceView.TitleH1, serviceView.TitleH2, serviceView.TitleH3, serviceView.BannerLink, serviceView.BannerLinkName, serviceView.Alias, serviceView.Description1, serviceView.ImgServicePage, serviceView.SortHeader);
                    return RedirectToAction("Index", "Service", new { area = "cp" });
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
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            ServiceView model = new ServiceView
            {
                Id = id,
                Title = service.Title,
                TitleH1 = service.TitleH1,
                TitleH2 = service.TitleH2,
                TitleH3 = service.TitleH3,
                BannerLink = service.BannerLink,
                BannerLinkName = service.BannerLinkName,
                Alias = service.Alias,
                Description1 = service.Description1,
                ImgServicePage = service.ImgServicePage,
                SortHeader = service.SortHeader
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(IFormFile imgServicePage, ServiceView serviceView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (imgServicePage != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + serviceView.ImgServicePage;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + imgServicePage.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            imgServicePage.CopyTo(stream);
                        }

                        serviceView.ImgServicePage = path;
                    }
                    _repository.ServiceEdit(serviceView.Id, serviceView.Title, serviceView.TitleH1, serviceView.TitleH2, serviceView.TitleH3, serviceView.BannerLink, serviceView.BannerLinkName, serviceView.Alias, serviceView.Description1, serviceView.ImgServicePage, serviceView.SortHeader);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(serviceView);
        }

        public IActionResult MainPage(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            MainView model = new MainView
            {
                Id = service.Id,
                Title = service.Title,
                Banner = service.Banner,
                Thumb = service.Thumb,
                ImgServiceList = service.ImgServiceList,
                ProductImg = service.ProductImg,
                TitleBanner = service.TitleBanner,
                SubTitleBanner = service.SubTitleBanner,
                LinkProduct = service.LinkProduct
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult MainPage(IFormFile banner, IFormFile thumb, IFormFile imgServiceList, IFormFile productImg, MainView mainView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (banner != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + mainView.Banner;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + banner.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            banner.CopyTo(stream);
                        }

                        mainView.Banner = path;
                    }

                    if (thumb != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + mainView.Thumb;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + thumb.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            thumb.CopyTo(stream);
                        }

                        mainView.Thumb = path;
                    }

                    if (imgServiceList != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + mainView.ImgServiceList;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + imgServiceList.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            imgServiceList.CopyTo(stream);
                        }

                        mainView.ImgServiceList = path;
                    }

                    if (productImg != null)
                    {
                        string fullPath = _appEnvironment.WebRootPath + mainView.ProductImg;

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);

                        var path = "/uploads/" + Guid.NewGuid() + productImg.FileName.ToLower();
                        using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                        {
                            productImg.CopyTo(stream);
                        }

                        mainView.ProductImg = path;
                    }

                    _repository.MainPageEdit(mainView.Id, mainView.TitleBanner, mainView.SubTitleBanner,
                        mainView.LinkProduct, mainView.Banner, mainView.Thumb, mainView.ImgServiceList,
                        mainView.ProductImg);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(mainView);
        }

        public IActionResult Album(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            AlbumView albumView = new AlbumView
            {
                Id = service.Id,
                Title = service.Title,
                AlbumId = service.AlbumId,
                TitleAlbum = service.TitleAlbum,
                LinkAlbum = service.LinkAlbum,
                Description2 = service.Description2
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
                    _repository.ServiceAlbum(albumView.Id, albumView.TitleAlbum, albumView.AlbumId, albumView.LinkAlbum, albumView.Description2);
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
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            VideoView videoView = new VideoView
            {
                Id = service.Id,
                Title = service.Title,
                TitleVideo = service.TitleVideo,
                LinkVideo = service.LinkVideo,
                Description3 = service.Description3,
                PreviewVideo = service.PreviewVideo
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

                    _repository.ServiceVideo(videoView.Id, videoView.TitleVideo, videoView.LinkVideo,
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
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            ProductView productView = new ProductView
            {
                Id = service.Id,
                Title = service.Title,
                TitleProducts = service.TitleProducts,
                Description4 = service.Description4
            };

            ViewBag.Products = new SelectList(_repository.GetProducts(), "Id", "Title");

            return View(productView);
        }

        public void AddProductForService(int serId, int prodId)
        {
            _repository.AddProductForService(serId, prodId);
        }

        [HttpPost]
        public IActionResult Material(ProductView productView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceProduct(productView.Id, productView.TitleProducts, productView.Description4);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(productView);
        }

        public IActionResult ServiceProductDelete(int productId, int serviceId)
        {
            ServiceProduct model = _repository.GetServiceProduct(productId, serviceId);

            if (model == null)
                return NotFound();

            _repository.ServiceProductDelete(model);

            return RedirectToAction("Material", "Service", new { area = "cp", id = serviceId });
        }

        public IActionResult Schema(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            SchemaView schemaView = new SchemaView
            {
                Id = service.Id,
                Title = service.Title,
                TitleSchema = service.TitleSchema,
                Description5 = service.Description5
            };

            return View(schemaView);
        }

        [HttpPost]
        public IActionResult Schema(SchemaView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceSchema(model.Id, model.TitleSchema, model.Description5);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }

        public IActionResult Calc(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            CalcView calcView = new CalcView
            {
                Id = service.Id,
                Title = service.Title,
                TitleCalc = service.TitleCalc,
                Description6 = service.Description6,
                CalcId = service.CalcId
            };

            ViewBag.CalcList = new SelectList(_repository.CalcCategories(), "Id", "Title");

            return View(calcView);
        }

        [HttpPost]
        public IActionResult Calc(CalcView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceCalc(model.Id, model.TitleCalc, model.Description6, model.CalcId);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            ViewBag.CalcList = new SelectList(_repository.CalcCategories(), "Id", "Title");
            return View(model);
        }

        public IActionResult Object(int id)
        {

            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            ObjectView objectView = new ObjectView
            {
                Id = service.Id,
                Title = service.Title,
                TitleObject = service.TitleObject,
                Description7 = service.Description7
            };

            ViewBag.Projects = new SelectList(_repository.GetProjects(), "Id", "Title");

            return View(objectView);
        }

        public void AddProjectForService(int serId, int projId)
        {
            _repository.AddProjectForService(serId, projId);
        }

        [HttpPost]
        public IActionResult Object(ObjectView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceObject(model.Id, model.TitleObject, model.Description7);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Projects = new SelectList(_repository.GetProjects(), "Id", "Title");
            return View(model);
        }

        public IActionResult ServiceProjectDelete(int projectId, int serviceId)
        {
            ServiceProject model = _repository.GetServiceProject(projectId, serviceId);

            if (model == null)
                return NotFound();

            _repository.ServiceProjectDelete(model);

            return RedirectToAction("Object", "Service", new { area = "cp", id = serviceId });
        }

        public IActionResult Area(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            AreaView areaView = new AreaView
            {
                Id = service.Id,
                Title = service.Title,
                TitleOblast = service.TitleOblast,
                Description8 = service.Description8
            };

            ViewBag.Floors = new SelectList(_repository.GetFloors(), "Id", "Title");
            return View(areaView);
        }

        public void AddFloorForService(int serId, int floorId)
        {
            _repository.AddFloorForService(serId, floorId);
        }

        [HttpPost]
        public IActionResult Area(AreaView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceArea(model.Id, model.TitleOblast, model.Description8);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Floors = new SelectList(_repository.GetFloors(), "Id", "Title");
            return View(model);
        }

        public IActionResult ServiceFloorDelete(int floorId, int serviceId)
        {
            ServiceFloor model = _repository.GetServiceFloor(floorId, serviceId);

            if (model == null)
                return NotFound();

            _repository.ServiceFloorDelete(model);

            return RedirectToAction("Area", "Service", new { area = "cp", id = serviceId });
        }

        public IActionResult Question(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            QuestionView questionView = new QuestionView
            {
                Id = service.Id,
                Title = service.Title,
                TitleQuestion = service.TitleQuestion,
                Description9 = service.Description9
            };

            ViewBag.Questions = new SelectList(_repository.GetArticles().Where(x => x.IsNews == false), "Id", "Title");
            return View(questionView);
        }

        public void AddQuestionForService(int serId, int artId)
        {
            _repository.AddQuestionForService(serId, artId);
        }

        [HttpPost]
        public IActionResult Question(QuestionView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ServiceQuestion(model.Id, model.TitleQuestion, model.Description9);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            ViewBag.Questions = new SelectList(_repository.GetArticles().Where(x => x.IsNews == false), "Id", "Title");
            return View(model);
        }

        public IActionResult ServiceQuestionDelete(int artId, int serviceId)
        {
            ServiceQuestion model = _repository.GetServiceQuestion(artId, serviceId);

            if (model == null)
                return NotFound();

            _repository.ServiceQuestionDelete(model);

            return RedirectToAction("Question", "Service", new { area = "cp", id = serviceId });
        }

        public IActionResult Seo(int id)
        {
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            SeoView seoView = new SeoView
            {
                Id = service.Id,
                Title = service.Title,
                SeoTitle = service.SeoTitle,
                SeoKeywords = service.SeoKeywords,
                SeoDescription = service.SeoDescription
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
                    _repository.ServiceSeo(seoView.Id, seoView.SeoTitle, seoView.SeoKeywords, seoView.SeoDescription);
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
            Service service = _repository.GetService(id);

            if (service == null)
                return NotFound();

            if (service.Banner != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.Banner;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (service.Thumb != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.Thumb;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (service.ProductImg != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.ProductImg;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (service.ImgServiceList != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.ImgServiceList;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (service.ImgServicePage != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.ImgServicePage;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }
            if (service.PreviewVideo != null)
            {
                string fullPath = _appEnvironment.WebRootPath + service.PreviewVideo;

                if (System.IO.File.Exists(fullPath))
                    System.IO.File.Delete(fullPath);
            }

            _repository.ServiceDeleteAllFloors(id);
            _repository.ServiceDeleteAllMaterials(id);
            _repository.ServiceDeleteAllProjects(id);
            _repository.ServiceDeleteAllQuestions(id);
            _repository.ServiceDelete(service);

            return RedirectToAction("Index", "Service", new { area = "cp" });
        }
    }
}