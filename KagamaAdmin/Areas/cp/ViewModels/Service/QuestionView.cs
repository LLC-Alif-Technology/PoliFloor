using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class QuestionView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для популярных вопросов")]
        public string TitleQuestion { get; set; }

        [Display(Name = "Описание")]
        public string Description9 { get; set; }
    }
}
