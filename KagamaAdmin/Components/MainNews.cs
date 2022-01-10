using System.Threading.Tasks;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainNews : ViewComponent
    {
        private IKagamaRepository _repository;
        public MainNews(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync() => View(await _repository.GetMainNewsAsync());
    }
}
