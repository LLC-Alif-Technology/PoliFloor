using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KagamaAdmin.Components
{
    public class MainFloors : ViewComponent
    {
        private IKagamaRepository _repository;
        public MainFloors(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _repository.GetFloorsAsync());
    }
}
