using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class RegionCategory
    {
        public int Id { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Url")]
        public string Alias { get; set; }
    }
}
