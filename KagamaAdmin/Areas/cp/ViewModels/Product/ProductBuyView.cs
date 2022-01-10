using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Product
{
    public class ProductBuyView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Метериалы")]
        public int ProductId { get; set; }
    }
}
