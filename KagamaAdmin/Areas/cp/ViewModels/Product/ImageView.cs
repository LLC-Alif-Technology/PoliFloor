using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Product
{
    public class ImageView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Изображение 1")]
        public string Img1 { get; set; }
        [Display(Name = "Изображение 2")]
        public string Img2 { get; set; }
        [Display(Name = "Изображение 3")]
        public string Img3 { get; set; }
    }
}
