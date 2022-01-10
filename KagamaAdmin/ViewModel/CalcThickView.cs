using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.ViewModel
{
    public class CalcThickView
    {
        public IEnumerable<CalcThick> CalcThicks { get; set; }

        public CalcCategory CalcCategory { get; set; }
    }
}
