using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Sign
{
    public class InView
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Поле 'Логин' обязательно")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Поле 'Пароль' обязательно")]
        public string Password { get; set; }

        [Display(Name = "Запомнить")]
        public bool IsPersistent { get; set; }
    }
}
