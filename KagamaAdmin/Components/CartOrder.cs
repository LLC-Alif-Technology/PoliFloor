using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class CartOrder : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CartOrderView model = new CartOrderView();
            return View(model);
        }
    }
}
