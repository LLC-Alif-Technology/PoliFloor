using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainCTA: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
