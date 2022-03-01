using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainRewards: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}