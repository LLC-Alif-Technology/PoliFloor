using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class StageOfWork: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
