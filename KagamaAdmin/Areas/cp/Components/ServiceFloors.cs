using KagamaAdmin.Areas.cp.ViewModels.Service;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ServiceFloors : ViewComponent
    {
        private IKagamaRepository _repository;
        public ServiceFloors(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddFloorView> model = from p in _repository.GetFloors()
                join i in _repository.GetServiceFloors(id) on p.Id equals i.FloorId
                select new AddFloorView
                {
                    Id = i.FloorId,
                    Title = p.Title,
                    ServiceId = i.ServiceId
                };

            return View(model);
        }
    }
}
