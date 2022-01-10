using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.Areas.cp.ViewModels.Calc
{
    public class CalcCategoryView
    {
        public CalcCategory CalcCategory { get; set; }

        public IEnumerable<CalcCategory> CalcCategories { get; set; }
    }
}
