using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class CalcOrderView
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

        [Display(Name = "Комментарий")]
        public string Description { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }

        [Display(Name = "Заголовок формы")]
        public string FormTitle { get; set; }

        [Display(Name = "Площадь")]
        public string FormArea { get; set; }

        [Display(Name = "Толщина")]
        public string FormThick { get; set; }

        [Display(Name = "Матовый лак")]
        public bool FormVarnish { get; set; }

        [Display(Name = "Результат рассчета")]
        public string TableRes { get; set; }

        [Display(Name = "Итого за 1 м2")]
        public string PriceRes1 { get; set; }

        [Display(Name = "Итого за все м2")]
        public string PriceRes2 { get; set; }
    }
}
