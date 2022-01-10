using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KagamaAdmin.Areas.cp.ViewModels.Video
{
    public class VideoView
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Thumb")]
        public string Thumb { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }

        [Display(Name = "Ссылка на видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "Категория")]
        public int? CategoryId { get; set; }
    }
}
