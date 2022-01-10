using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class ContactsController : Controller
    {
        private IKagamaRepository _repository;
        public ContactsController(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string sortOrder, string search)
        {
            IEnumerable<Contact> model = _repository.GetContacts();

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
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ContactCreate(model);
                    return RedirectToAction("Index", "Contacts", new { area = "cp" });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Contact model = _repository.GetContact(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Contact model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.ContactEdit(model);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Contact model = _repository.GetContact(id);

            if (model == null)
                return NotFound();

            _repository.ContactDelete(model);

            return RedirectToAction("Index", "Contacts", new { area = "cp" });
        }
    }
}