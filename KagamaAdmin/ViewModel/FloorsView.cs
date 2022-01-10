using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.ViewModel
{
    public class FloorsView
    {
        public Page Page { get; set; }

        public IEnumerable<Floor> Floors { get; set; }

        public Floor Floor { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public CartView CartView { get; set; }

        public IEnumerable<Article> Questions { get; set; }

        public decimal EUR { get; set; }
    }
}
