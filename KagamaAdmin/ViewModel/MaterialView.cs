using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class MaterialView
    {
        public IEnumerable<Product> Products { get; set; }

        public CartView CartView { get; set; }

        public decimal EUR { get; set; }
    }
}
