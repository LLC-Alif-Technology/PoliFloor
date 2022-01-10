using KagamaModels.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Gallery
{
    public class GalleryView
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Изображение")]
        public string Icon { get; set; }

        public IEnumerable<GalleryAlbum> GalleryAlbums { get; set; }

        public int[] MyCheck { get; set; }

        public int? PreviousPage { get; set; }
    }
}
