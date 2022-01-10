using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Video
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

        [Display(Name = "Thumb")]
        public string Thumb { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }

        [Display(Name = "Ссылка на видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }

        [Display(Name = "Категория")]
        public int? CategoryId { get; set; }
    }
}
