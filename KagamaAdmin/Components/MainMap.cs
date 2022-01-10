using System.Threading.Tasks;
using KagamaAdmin.ViewModel;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Components
{
    public class MainMap : ViewComponent
    {
        private IKagamaRepository _repository;
        public MainMap(IKagamaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Contact contact = await _repository.GetMainContactAsync();

            MainMapView model = new MainMapView
            {
                Schedule = contact.Schedule,
                Address = contact.Address,
                Email = contact.Email,
                Phone = contact.Phone
            };

            return View(model);
        }
    }
}
