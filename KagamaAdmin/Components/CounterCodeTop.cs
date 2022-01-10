using System.Threading.Tasks;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class CounterCodeTop : ViewComponent
    {
        private IKagamaRepository _repository;
        public CounterCodeTop(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _repository.CountersAsync());
    }
}
