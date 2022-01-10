using System.Collections.Generic;
using System.Linq;
using KagamaAdmin.Areas.cp.ViewModels.Product;
using KagamaModels;
using Microsoft.AspNetCore.Mvc;

namespace KagamaAdmin.Areas.cp.Components
{
    public class ProductBuy : ViewComponent
    {
        private IKagamaRepository _repository;
        public ProductBuy(IKagamaRepository repository)
        {
            _repository = repository;
        }
        public IViewComponentResult Invoke(int id)
        {
            IEnumerable<ProductBuyView> model = from p in _repository.GetProducts()
                join i in _repository.GetProductBuys(id) on p.Id equals i.ProductId
                select new ProductBuyView
                {
                    Id = i.ThisProductId,
                    Title = p.Title,
                    ProductId = i.ProductId
                };

            return View(model);
        }
    }
}
