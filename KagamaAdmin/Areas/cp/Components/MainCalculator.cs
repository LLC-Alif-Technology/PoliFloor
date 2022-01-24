using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainCalculator: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}