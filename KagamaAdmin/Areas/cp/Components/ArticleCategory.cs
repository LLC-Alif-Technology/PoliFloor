using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ArticleCategory : ViewComponent
    {
        private IKagamaRepository _repository;
        public ArticleCategory(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke() => View(_repository.ArticleCategories());
    }
}
