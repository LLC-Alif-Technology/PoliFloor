using KagamaAdmin.ViewModel;
using KagamaModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace KagamaAdmin.Components
{
    public class MainMaterials : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private IKagamaRepository _repository;
        public MainMaterials(IKagamaRepository repository, IHttpContextAccessor httpContextAccessor)
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
            MaterialView model = new MaterialView
            {
                Products = await _repository.GetProductsTakeAsync(),
                CartView = GetCart(),
                EUR = _repository.GetEurCourse("eur").Course
            };

            return View(model);
        }
    }
}
