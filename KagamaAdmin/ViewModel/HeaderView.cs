using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class HeaderView
    {
        public string Phone { get; set; }

        public CartView CartView { get; set; }

        public IEnumerable<Service> Services { get; set; }
    }
}
