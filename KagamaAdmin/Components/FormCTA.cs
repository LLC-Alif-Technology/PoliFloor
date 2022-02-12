using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class FormCTA: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
