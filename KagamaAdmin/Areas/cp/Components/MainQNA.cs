using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainQNA: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}