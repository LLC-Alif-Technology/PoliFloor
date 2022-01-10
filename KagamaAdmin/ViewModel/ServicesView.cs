using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class ServicesView
    {
        public Page Page { get; set; }

        public IEnumerable<Service> Services { get; set; }

        public Service Service { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public decimal EUR { get; set; }

        public CartView CartView { get; set; }

        public IEnumerable<Project> Projects { get; set; }

        public IEnumerable<Floor> Floors { get; set; }

        public IEnumerable<Article> Articles { get; set; }

        public CalcCategory CalcCategory { get; set; }

        public IEnumerable<CalcThick> CalcThicks { get; set; }

        public IEnumerable<CalcProduct> CalcProducts { get; set; }

        [Display(Name = "Площадь")]
        public int Area { get; set; }

        [Display(Name = "Толщина")]
        public int Thick { get; set; }

        [Display(Name = "Лак")]
        public string Varnish { get; set; }

        [Display(Name = "Поверхность ")]
        public string Surface { get; set; }

        public float AllKg { get; set; }

        public decimal TotalSum_1m2 { get; set; }

        public decimal TotalSum { get; set; }
    }
}
