using KagamaAdmin.Areas.cp.ViewModels.Service;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ServiceProducts : ViewComponent
    {
        private IKagamaRepository _repository;
        public ServiceProducts(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddProductView> model = from p in _repository.GetProducts()
                                                join i in _repository.GetServiceProducts(id) on p.Id equals i.ProductId
                                                select new AddProductView
                                                {
                                                    Id = i.ProductId,
                                                    Title = p.Title,
                                                    ServiceId = i.ServiceId
                                                };

            return View(model);
        }
    }
}
