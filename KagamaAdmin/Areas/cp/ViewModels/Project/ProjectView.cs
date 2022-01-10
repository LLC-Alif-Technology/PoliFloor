using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Project
{
    public class ProjectView
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле 'Заголовок' обязательно")]
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
    }
}
