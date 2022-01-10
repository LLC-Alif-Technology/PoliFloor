using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.ViewModel
{
    public class MainMapView
    {
        [Display(Name = "График работы")]
        public string Schedule { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Почта")]
        public string Email { get; set; }

        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
    }
}
