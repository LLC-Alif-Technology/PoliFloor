using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Floor
{
    public class ProductView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для материалов")]
        public string TitleProducts { get; set; }

        [Display(Name = "Описание")]
        public string Description3 { get; set; }
    }
}
