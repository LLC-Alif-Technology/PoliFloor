using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class RegionCategory : ViewComponent
    {
        private IKagamaRepository _repository;
        public RegionCategory(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.RegionCategories());
    }
}
