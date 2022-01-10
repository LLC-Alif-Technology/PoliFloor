using KagamaAdmin.Areas.cp.ViewModels.Region;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Components
{
    public class RegionProducts : ViewComponent
    {
        private IKagamaRepository _repository;
        public RegionProducts(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddProductView> model = from p in _repository.GetProducts()
                                                join i in _repository.GetRegionProducts(id) on p.Id equals i.ProductId
                                                select new AddProductView
                                                {
                                                    Id = i.ProductId,
                                                    Title = p.Title,
                                                    RegionId = i.RegionId
                                                };

            return View(model);
        }
    }
}
