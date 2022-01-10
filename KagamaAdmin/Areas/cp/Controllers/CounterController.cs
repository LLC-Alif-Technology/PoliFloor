using KagamaModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KagamaModels.Entities;
using System;

namespace KagamaAdmin.Areas.cp.Controllers
{
    [Area("cp")]
    [Authorize]
    public class CounterController : Controller
    {
        private IKagamaRepository _repository;
        public CounterController(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index() => View(_repository.Counters().ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Counter model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CounterCreate(model);
                    return RedirectToAction("Index", "Counter", new { area = "cp" });
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
            Counter model = _repository.GetCounter(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Counter model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.CounterEdit(model);
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
            Counter model = _repository.GetCounter(id);

            if (model == null)
                return NotFound();

            _repository.CounterDelete(model);

            return RedirectToAction("Index", "Counter", new { area = "cp" });
        }
    }
}