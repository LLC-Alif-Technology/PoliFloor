using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Floor
{
    public class FloorView
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле 'Заголовок' обязательно")]
        public string Title { get; set; }

        [Display(Name = "Иконка")]
        public string Icon { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание")]
        public string Description1 { get; set; }
    }
}
