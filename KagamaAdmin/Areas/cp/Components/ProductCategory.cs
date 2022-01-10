using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ProductCategory : ViewComponent
    {
        private IKagamaRepository _repository;
        public ProductCategory(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.ProductCategories());
    }
}
