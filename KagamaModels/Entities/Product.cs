using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Url")]
        public string Alias { get; set; }
        [Display(Name = "Подзаголовок")]
        public string SubTitle { get; set; }
        [Display(Name = "В наличии")]
        public bool Stock { get; set; }
        [Display(Name = "Цена за 1 кг")]
        public decimal? PriceKg { get; set; }
        [Display(Name = "Цена за комплект")]
        public  decimal? PriceKit { get; set; }
        [Display(Name = "Ссылка на видео")]
        public string LinkVideo { get; set; }
        [Display(Name = "Сертификаты Pdf")]
        public string Pdf { get; set; }
        [Display(Name = "Описание")]
        public string Desc1 { get; set; }
        [Display(Name = "Технические характеристики")]
        public string Desc2 { get; set; }
        [Display(Name = "Указания по применению")]
        public string Desc3 { get; set; }
        [Display(Name = "Особенности")]
        public string Desc4 { get; set; }
        [Display(Name = "Области применения")]
        public string Desc5 { get; set; }
        [Display(Name = "Описание под материалами")]
        public string Desc6 { get; set; }
        [Display(Name = "Изображение 1")]
        public string Img1 { get; set; }
        [Display(Name = "Изображение 2")]
        public string Img2 { get; set; }
        [Display(Name = "Изображение 3")]
        public string Img3 { get; set; }
        [Display(Name = "Категория")]
        public int? ProductCategoryId { get; set; }
        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }
        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }
        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
