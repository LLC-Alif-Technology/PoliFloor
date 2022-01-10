using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class ModalLead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ModalLeadView model = new ModalLeadView();
            return View(model);
        }
    }
}
