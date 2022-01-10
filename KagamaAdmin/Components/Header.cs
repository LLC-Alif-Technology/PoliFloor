using KagamaAdmin.ViewModel;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace KagamaAdmin.Components
{
    public class Header : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        private IKagamaRepository _repository;
        public Header(IKagamaRepository repository, IHttpContextAccessor httpContextAccessor)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
        }
        protected T GetSession<T>(ISession session, string name)
        {
            var value = session.GetString(name);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }

        protected void SetSession(ISession session, string name, object value)
        {
            session.SetString(name, JsonConvert.SerializeObject(value));
        }
        protected CartView GetCart()
        {
            var cart = GetSession<CartView>(_session, "cart");

            if (cart == null)
            {
                cart = new CartView();
                SetSession(_session, "cart", cart);
            }

            return cart;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Contact contact = await _repository.GetMainContactAsync();

            HeaderView model = new HeaderView
            {
                Phone = contact.Phone,
                CartView = GetCart(),
                Services = await _repository.GetServicesAsync()
            };

            return View(model);
        }
    }
}
