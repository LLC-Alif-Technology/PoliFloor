using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class ModalCallView
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string ModalCallName { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string ModalCallPhone { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
