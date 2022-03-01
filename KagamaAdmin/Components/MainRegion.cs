using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainRegion: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
