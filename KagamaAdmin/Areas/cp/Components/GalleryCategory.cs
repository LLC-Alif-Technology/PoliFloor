using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class GalleryCategory : ViewComponent
    {
        private IKagamaRepository _repository;
        public GalleryCategory(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.GalleryCategories());
    }
}
