using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class QuestionsTabView
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

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Ваш вопрос")]
        public string Description { get; set; }

        [Display(Name = "Страница заявки")]
        public string PageUrl { get; set; }
    }
}
