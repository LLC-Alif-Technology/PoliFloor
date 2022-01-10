using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class AreaView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для области применения")]
        public string TitleOblast { get; set; }

        [Display(Name = "Описание")]
        public string Description8 { get; set; }
    }
}
