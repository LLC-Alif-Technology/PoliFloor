using KagamaModels.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Calc
{
    public class CalcProductView
    {
        public int ThisId { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

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

        [Display(Name = "Мм")]
        public int Mm { get; set; }

        [Display(Name = "Реком. расход")]
        public string[] Kg { get; set; }

        public int ProductId { get; set; }

        public IEnumerable<CalcThick> CalcThicks { get; set; }

        public IEnumerable<CalcProduct> CalcProducts { get; set; }
    }
}
