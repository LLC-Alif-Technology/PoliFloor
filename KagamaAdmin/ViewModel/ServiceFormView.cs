using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class ServiceFormView
    {
        [Display(Name = "Имя")]
        public string SoName { get; set; }

        [Display(Name = "Email")]
        public string SoEmail { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string SoPhone { get; set; }

        [Display(Name = "Количество м2")]
        public string SoCount { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
