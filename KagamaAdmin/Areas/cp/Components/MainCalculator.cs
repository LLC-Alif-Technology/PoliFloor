using System.Linq;
using KagamaAdmin.ViewModel;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KagamaAdmin.Components
{
    public class MainCalculator: ViewComponent
    {
        private readonly IKagamaRepository _repository;

        public MainCalculator(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke () 
        {

            Page page = _repository.GetPageAsync("Kalkulyator").Result;

            CalculatorView model = new CalculatorView
            {
                Page = page,
                CalcCategories = _repository.CalcCategories()
            };

            model.CalcImages = _repository.GetServices().Where(x=>x.CalcId != null).ToDictionary(x=>(int)x.CalcId, x=>x.Banner);

            model.Prices = _repository.GetProductPrices(model.CalcCategories.First().Id);

            model.TicksDictionary = _repository.GetCalcTicks().GroupBy(x=>x.CalcCategoryId).ToDictionary(x=>x.Key, x=>x.ToList());

            return View(model);
        } 
            
    }
}