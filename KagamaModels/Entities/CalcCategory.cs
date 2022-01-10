using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class CalcCategory
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Title { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Описание")]
        public string Desc { get; set; }

        [Display(Name = "Глянцевый лак")]
        public bool Glossy { get; set; }

        [Display(Name = "Полуматовый лак")]
        public bool SemiMatt { get; set; }

        [Display(Name = "Матовый лак")]
        public bool Matt { get; set; }

        [Display(Name = "Гладкая")]
        public bool Smooth { get; set; }

        [Display(Name = "Шероховатая")]
        public bool Grungy { get; set; }

        public string Alias { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
