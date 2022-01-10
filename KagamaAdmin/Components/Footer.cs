using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KagamaAdmin.Components
{
    public class Footer : ViewComponent
    {
        private IKagamaRepository _repository;
        public Footer(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _repository.GetServicesAsync());
    }
}
