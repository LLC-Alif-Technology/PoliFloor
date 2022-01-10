using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class GalleryView
    {
        public Page Page { get; set; }

        public IEnumerable<GalleryCategory> GalleryCategories { get; set; }

        public IEnumerable<GalleryAlbum> GalleryAlbums { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }

        public int SelectGalleryCategoryId { get; set; }

        public int SelectGalleryAlbumId { get; set; }

        public string GalleryH1 { get; set; }
    }
}