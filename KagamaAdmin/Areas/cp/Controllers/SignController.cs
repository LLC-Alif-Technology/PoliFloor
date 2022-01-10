using KagamaAdmin.Areas.cp.ViewModels.Sign;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    public class SignController : Controller
    {
        private IKagamaRepository _repository;

        public SignController(IKagamaRepository repository)
        {
            _repository = repository;
        }

        private async Task Authenticate(string userName, bool isPersistent)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            var p = new AuthenticationProperties
            {
                IsPersistent = isPersistent
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id), p);
        }

        [HttpGet]
        public IActionResult In(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> In(InView model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AdminUser adminUser = await _repository.GetAdminUser(model.Login, model.Password);

                    if (adminUser != null)
                    {
                        await Authenticate(model.Login, model.IsPersistent);

                        return Redirect(returnUrl ?? Url.Action("Index", "Home", new { area = "cp" }));
                    }

                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Out()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index", "home", new { area = "" });
        }
    }
}