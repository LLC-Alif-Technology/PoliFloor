using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainLead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MainLeadView model = new MainLeadView();
            return View(model);
        }
    }
}
