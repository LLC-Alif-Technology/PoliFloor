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
using System.Threading.Tasks;
using KagamaAdmin.ViewModel;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ReviewController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;

        public ReviewController(IKagamaRepository repository, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            ReviewView model = new ReviewView
            {
                Review = await _repository.GetAllReview()
            };
            return View(model);
        }

    }
}   