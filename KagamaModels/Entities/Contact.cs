using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Якорь")]
        public string Anchor { get; set; }

        [Display(Name = "Код карты")]
        public string CodeMap { get; set; }

        [Display(Name = "График работы")]
        public string Schedule { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }

        [Display(Name = "Головной офис")]
        public bool IsMain { get; set; }

        [Display(Name = "Url")]
        public string UrltoPageRegion { get; set; }
    }
}
