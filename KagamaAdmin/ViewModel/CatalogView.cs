using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class CatalogView
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<ProductCategory> ProductCategories { get; set; }

        public Page Page { get; set; }

        public Product ProductOpen { get; set; }

        public CartView CartView { get; set; }

        public IEnumerable<Product> ProductBuys { get; set; }

        public string ProductCategoryH1 { get; set; }

        public string ProductCategoryDesc { get; set; }

        public decimal EUR { get; set; }
    }
}
