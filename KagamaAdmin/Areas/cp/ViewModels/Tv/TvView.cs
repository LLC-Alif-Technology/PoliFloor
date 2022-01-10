using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KagamaAdmin.Areas.cp.ViewModels.Tv
{
    public class TvView
    {
        public int Id { get; set; }

        [Display(Name = "Иконка")]
        public string Icon { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }

        [Display(Name = "Надпись над заголовком")]
        public string Caption { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле 'Заголовок' обязательно")]
        public string Title { get; set; }

        [Display(Name = "ПодЗаголовок")]
        public string SubTitle { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание")]
        public string Description1 { get; set; }

        [Display(Name = "Мы на тв / Обучение -  да/нет")]
        public bool IsTv { get; set; }
    }
}
