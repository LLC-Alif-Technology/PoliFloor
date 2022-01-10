using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class CartSuccess: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
