using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class ModalLeadView
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string MName { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string MEmail { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string MPhone { get; set; }

        [Display(Name = "Выбор покрытия")]
        public string[] MCovering { get; set; }

        [Display(Name = "Площадь")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string MSquare { get; set; }

        [Display(Name = "Город")]
        public string MCity { get; set; }

        [Display(Name = "Адрес")]
        public string MAddress { get; set; }

        [Display(Name = "Комментарий")]
        public string MDescription { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
