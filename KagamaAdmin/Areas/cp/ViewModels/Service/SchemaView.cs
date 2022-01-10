using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class SchemaView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для взрыв схемы")]
        public string TitleSchema { get; set; }

        [Display(Name = "Описание")]
        public string Description5 { get; set; }
    }
}
