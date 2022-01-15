using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainProperties: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}