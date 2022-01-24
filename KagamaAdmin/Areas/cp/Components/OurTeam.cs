using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class OurTeam: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}