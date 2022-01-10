using System.Collections.Generic;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Floor;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class FloorQuestions : ViewComponent
    {
        private IKagamaRepository _repository;
        public FloorQuestions(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<AddQuestionView> model = from p in _repository.GetArticles()
                join i in _repository.GetFloorQuestions(id) on p.Id equals i.ArtId
                select new AddQuestionView
                {
                    Id = i.ArtId,
                    Title = p.Title,
                    FloorId = i.FloorId
                };

            return View(model);
        }
    }
}
