using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class VideoCategory : ViewComponent
    {
        private IKagamaRepository _repository;
        public VideoCategory(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.VideoCategories());
    }
}
