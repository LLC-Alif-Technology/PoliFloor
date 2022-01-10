using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Article
{
    public class ImageView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Изображение")]
        public string Img { get; set; }

        [Display(Name = "Изображение на открытой статье")]
        public string ImgOpenPage { get; set; }
    }
}
