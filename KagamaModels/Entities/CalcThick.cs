using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class CalcThick
    {
        public int Id { get; set; }

        [Display(Name = "Толщина в мм")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public int Mm { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        public int CalcCategoryId { get; set; }
    }
}
