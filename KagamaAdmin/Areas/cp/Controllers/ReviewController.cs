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
using System.Xml.Linq;
using KagamaAdmin.ViewModel;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ReviewController : Controller
    {
        private IKagamaRepository _repository;
        private IHostingEnvironment _appEnvironment;
        private readonly EFDBContext _context;

        public ReviewController(IKagamaRepository repository, IHostingEnvironment appEnvironment, EFDBContext context)
        {
            _repository = repository;
            _appEnvironment = appEnvironment;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ReviewView model = new ReviewView
            {
                
                Review = await _repository.GetAllReview(),
                Services = await _repository.GetAllServices()
                
            };
            
            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateReview(int  ReviewId, int ServiceId, ReviewView model)
        {
            
             var FindReview = await _repository.GetReviewById(ReviewId);
             
             // Alternate between true and false
            FindReview.IsAllowed = !FindReview.IsAllowed;
            //FindReview.ServiceId = ServiceId;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
    }
}   