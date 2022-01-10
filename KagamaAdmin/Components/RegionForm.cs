using KagamaAdmin.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class RegionForm: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            RegionFormView model = new RegionFormView();
            return View(model);
        }
    }
}
