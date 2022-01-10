using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class CalcView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для калькулятора")]
        public string TitleCalc { get; set; }

        [Display(Name = "Описание")]
        public string Description6 { get; set; }

        [Display(Name = "Id калькулятора")]
        public int? CalcId { get; set; }
    }
}
