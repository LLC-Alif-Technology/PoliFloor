
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Floor;

namespace KagamaAdmin.Areas.cp.Components
{
    public class FloorProducts : ViewComponent
    {
        private IKagamaRepository _repository;
        public FloorProducts(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddProductView> model = from p in _repository.GetProducts()
                join i in _repository.GetFloorProducts(id) on p.Id equals i.ProductId
                select new AddProductView
                {
                    Id = i.ProductId,
                    Title = p.Title,
                    FloorId = i.FloorId
                };

            return View(model);
        }
    }
}
