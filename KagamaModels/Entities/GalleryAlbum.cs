using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class GalleryAlbum
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Title { get; set; }

        [Display(Name = "H1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public uint GalleryCategoryId { get; set; }

        [Display(Name = "Показать/Скрыть")]
        public bool Show { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
