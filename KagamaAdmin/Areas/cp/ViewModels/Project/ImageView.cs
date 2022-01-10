using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Project
{
    public class ImageView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Изображение на др страницах")]
        public string Img { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }
    }
}
