using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class RegionsView
    {
        public Page Page { get; set; }

        public IEnumerable<RegionCategory> RegionCategories { get; set; }

        public IEnumerable<Region> Regions { get; set; }

        public Region Region { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public CartView CartView { get; set; }

        public decimal EUR { get; set; }
    }
}
