using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KagamaAdmin.Components
{
    public class MainSellingVideo : ViewComponent
    {
        private IKagamaRepository _repository;
        public MainSellingVideo(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _repository.GetServicesAsync());
    }
}
