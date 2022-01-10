using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class ServiceForm : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ServiceFormView model = new ServiceFormView();
            return View(model);
        }
    }
}
