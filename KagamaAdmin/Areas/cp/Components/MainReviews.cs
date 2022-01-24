using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainReviews: ViewComponent
    {
        public IViewComponentResult Invoke ()=> View();
    }
}