using KagamaModels.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class CalculatorView
    {
        public Page Page { get; set; }

        public CalcCategory CalcCategory { get; set; }

        public IEnumerable<CalcCategory> CalcCategories { get; set; }

        public IEnumerable<CalcThick> CalcThicks { get; set; }

        public IEnumerable<CalcProduct> CalcProducts { get; set; }

        [Display(Name = "Площадь")]
        public int Area { get; set; }

        [Display(Name = "Толщина")]
        public int Thick { get; set; }

        [Display(Name = "Лак")]
        public string Varnish { get; set; }

        [Display(Name = "Поверхность ")]
        public string Surface { get; set; }

        public float AllKg { get; set; }

        public decimal TotalSum_1m2 { get; set; }

        public decimal TotalSum { get; set; }

        public decimal EUR { get; set; }
    }
}
