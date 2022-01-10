using KagamaAdmin.Areas.cp.ViewModels.Service;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ServiceProjects : ViewComponent
    {
        private IKagamaRepository _repository;
        public ServiceProjects(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddProjectView> model = from p in _repository.GetProjects()
                join i in _repository.GetServiceProjects(id) on p.Id equals i.ProjectId
                select new AddProjectView
                {
                    Id = i.ProjectId,
                    Title = p.Title,
                    ServiceId = i.ServiceId
                };

            return View(model);
        }
    }
}
