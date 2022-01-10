using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name = "Изображение на др страницах")]
        public string Img { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Площадь")]
        public string Square { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Цена")]
        public decimal? Price { get; set; }

        [Display(Name = "Заголовок для альбома")]
        public string TitleAlbum { get; set; }

        [Display(Name = "Id альбома")]
        public int? AlbumId { get; set; }

        [Display(Name = "Ссылка на альбом")]
        public string LinkAlbum { get; set; }

        [Display(Name = "Описание ck_editor1")]
        public string Description1 { get; set; }

        [Display(Name = "Заголовок для видео")]
        public string TitleVideo { get; set; }

        [Display(Name = "Ссылка для видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "Превью для видео")]
        public string PreviewVideo { get; set; }

        [Display(Name = "Описание ck_editor2")]
        public string Description2 { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
