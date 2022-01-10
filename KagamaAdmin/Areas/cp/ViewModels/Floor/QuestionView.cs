using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KagamaAdmin.Areas.cp.ViewModels.Floor
{
    public class QuestionView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для популярных вопросов")]
        public string TitleQuestion { get; set; }

        [Display(Name = "Описание")]
        public string Description4 { get; set; }
    }
}
