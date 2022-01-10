using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class RegionFormView
    {
        [Display(Name = "Имя")]
        public string ReName { get; set; }

        [Display(Name = "Email")]
        public string ReEmail { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string RePhone { get; set; }

        [Display(Name = "Количество м2")]
        public string ReCount { get; set; }

        [Display(Name = "Выбор покрытия")]
        public string[] ReCovering { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
