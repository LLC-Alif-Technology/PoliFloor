using System;
using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class CalculatorViewModel 
    {
        public int CalId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public IEnumerable<CalcThick> Ticks {get;set;}
    }
}