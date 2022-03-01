using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainOurTeam: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
