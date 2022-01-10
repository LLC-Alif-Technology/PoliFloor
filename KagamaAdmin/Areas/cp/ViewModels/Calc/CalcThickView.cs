using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.Areas.cp.ViewModels.Calc
{
    public class CalcThickView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CalcThick CalcThick { get; set; }
        public IEnumerable<CalcThick> CalcThicks { get; set; }
    }
}
