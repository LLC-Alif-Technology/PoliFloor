using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class CalcOrder : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CalcOrderView model = new CalcOrderView();
            return View(model);
        }
    }
}
