using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class QuestionsTab : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            QuestionsTabView model = new QuestionsTabView();
            return View(model);
        }
    }
}
