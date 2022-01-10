using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class ServiceView
    {
        public int Id { get; set; }

        [Display(Name = "Изображение на странице открытой услуги")]
        public string ImgServicePage { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле 'Заголовок' обязательно")]
        public string Title { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Заголовок h2")]
        public string TitleH2 { get; set; }

        [Display(Name = "Заголовок h3")]
        public string TitleH3 { get; set; }

        [Display(Name = "Ссылка на банере")]
        public string BannerLink { get; set; }

        [Display(Name = "Название ссылки на банере")]
        public string BannerLinkName { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание")]
        public string Description1 { get; set; }

        [Display(Name = "Сортировка услуг в шапке ")]
        public int? SortHeader { get; set; }
    }
}
