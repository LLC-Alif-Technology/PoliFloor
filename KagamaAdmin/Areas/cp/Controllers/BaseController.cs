using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class BaseController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public BaseController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("upload_ck_editor")]
        [HttpPost]
        public IActionResult UploadCkEditor(IFormFile upload)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ck_uploads", fileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);
            }

            var url = $"{"/ck_uploads/"}{fileName}";
            var successMessage = "image is uploaded successfully";
            dynamic success = JsonConvert.DeserializeObject("{ 'uploaded': 1,'fileName': \"" + fileName + "\",'url': \"" + url + "\", 'error': { 'message': \"" + successMessage + "\"}}");

            return Json(success);
        }

        [Route("filebrowse")]
        [HttpGet]
        public IActionResult FileBrowse()
        {
            var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath,
                "ck_uploads"));
            ViewBag.fileInfos = dir.GetFiles();
            return View();
        }
    }
}