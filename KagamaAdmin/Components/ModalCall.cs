using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class ModalCall : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ModalCallView model = new ModalCallView();
            return View(model);
        }
    }
}
