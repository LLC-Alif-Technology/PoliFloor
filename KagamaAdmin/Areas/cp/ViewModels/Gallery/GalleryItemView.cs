using KagamaModels.Entities;
using PagedList.Core;

namespace KagamaAdmin.Areas.cp.ViewModels.Gallery
{
    public class GalleryItemView
    {
        public PagedList<GalleryItem> GalleryItems { get; set; }
    }
}
