using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Region
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }

        [Display(Name = "Индекс города")]
        public string Index { get; set; }

        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }

        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Заголовок для альбома")]
        public string TitleAlbum { get; set; }

        [Display(Name = "Id альбома")]
        public int? AlbumId { get; set; }

        [Display(Name = "Ссылка на альбом")]
        public string LinkAlbum { get; set; }

        [Display(Name = "Описание ck_editor2")]
        public string Description2 { get; set; }

        [Display(Name = "Заголовок для видео")]
        public string TitleVideo { get; set; }

        [Display(Name = "Ссылка для видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "Превью для видео")]
        public string PreviewVideo { get; set; }

        [Display(Name = "Описание ck_editor3")]
        public string Description3 { get; set; }

        [Display(Name = "Заголовок для продуктов")]
        public string TitleProducts { get; set; }

        [Display(Name = "Описание ck_editor4")]
        public string Description4 { get; set; }
    }
}
