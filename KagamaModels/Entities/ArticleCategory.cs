using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class ArticleCategory
    {
        public int Id { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Url")]
        public string Alias { get; set; }
        [Display(Name = "Новость да/нет")]
        public bool IsNews { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
