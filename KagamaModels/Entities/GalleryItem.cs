using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class GalleryItem
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Изображение")]
        public string Icon { get; set; }
    }
}
