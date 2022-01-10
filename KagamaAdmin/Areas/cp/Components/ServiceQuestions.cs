using KagamaAdmin.Areas.cp.ViewModels.Service;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ServiceQuestions : ViewComponent
    {
        private IKagamaRepository _repository;
        public ServiceQuestions(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddQuestionView> model = from p in _repository.GetArticles()
                join i in _repository.GetServiceQuestions(id) on p.Id equals i.ArticleId
                select new AddQuestionView
                {
                    Id = i.ArticleId,
                    Title = p.Title,
                    ServiceId = i.ServiceId
                };

            return View(model);
        }
    }
}
