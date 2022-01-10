using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class ObjectView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для готовых объектов")]
        public string TitleObject { get; set; }

        [Display(Name = "Описание")]
        public string Description7 { get; set; }
    }
}
