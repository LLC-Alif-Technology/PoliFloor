using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class MainGalleryView
    {
        public GalleryAlbum GalleryAlbum { get; set; }
        public IEnumerable<GalleryItem> GalleryItems { get; set; } 
        public IEnumerable<Video> Videos { get; set; }
        public string VideoDesc { get; set; }
    }
}
