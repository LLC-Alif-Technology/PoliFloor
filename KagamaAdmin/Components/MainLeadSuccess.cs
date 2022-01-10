using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainLeadSuccess : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
