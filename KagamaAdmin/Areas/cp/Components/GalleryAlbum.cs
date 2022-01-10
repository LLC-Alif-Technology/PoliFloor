using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class GalleryAlbum : ViewComponent
    {
        private IKagamaRepository _repository;
        public GalleryAlbum(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.GalleryAlbums());
    }
}
