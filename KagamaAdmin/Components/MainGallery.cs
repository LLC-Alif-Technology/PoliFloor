using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using KagamaAdmin.ViewModel;
using KagamaModels.Entities;

namespace KagamaAdmin.Components
{
    public class MainGallery : ViewComponent
    {
        private IKagamaRepository _repository;
        public MainGallery(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Page page = await _repository.GetPageAsync("Obuchenie");

            MainGalleryView model = new MainGalleryView();

            model.GalleryAlbum = await _repository.GetGalleryAlbumAsyncAll("Glavnaya-stranica");

            model.GalleryItems = await _repository.GetGalleryItemAsync(model.GalleryAlbum.Id);

            model.Videos = await _repository.GetMainVideosAsync();

            model.VideoDesc = page.Description;

            return View(model);
        }
    }
}
