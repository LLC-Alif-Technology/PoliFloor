using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class CalcProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CalcCategoryId { get; set; }

        [Display(Name = "Глянцевый лак")]
        public bool Glossy { get; set; }

        [Display(Name = "Полуматовый лак")]
        public bool SemiMatt { get; set; }

        [Display(Name = "Матовый лак")]
        public bool Matt { get; set; }

        [Display(Name = "Гладкая")]
        public bool Smooth { get; set; }

        [Display(Name = "Шероховатая")]
        public bool Grungy { get; set; }

        [Display(Name = "Реком. расход")]
        public string Kg { get; set; }

        [Display(Name = "Название материала")]
        public string PrTitle { get; set; }

        [Display(Name = "Цена товара за кг")]
        public decimal? PrPriceKg { get; set; }

        [Display(Name = "Цена товара за комплект")]
        public decimal? PrPriceKit { get; set; }
    }
}
