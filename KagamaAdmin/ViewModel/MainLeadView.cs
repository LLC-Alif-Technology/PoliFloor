using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class MainLeadView
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Name { get; set; }

        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Email { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Phone { get; set; }

        [Display(Name = "Выбор покрытия")]
        public string[] Covering { get; set; }

        [Display(Name = "Площадь")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Square { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Комментарий")]
        public string Description { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
