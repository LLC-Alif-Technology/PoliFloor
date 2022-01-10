using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class VideoView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для видео")]
        public string TitleVideo { get; set; }

        [Display(Name = "Ссылка для видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "Превью для видео")]
        public string PreviewVideo { get; set; }

        [Display(Name = "Описание")]
        public string Description3 { get; set; }
    }
}
