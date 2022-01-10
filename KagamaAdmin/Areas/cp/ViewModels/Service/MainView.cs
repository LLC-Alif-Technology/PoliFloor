using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Service
{
    public class MainView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Thumb изображение на главной странице")]
        public string Thumb { get; set; }

        [Display(Name = "Банер на главной странице")]
        public string Banner { get; set; }

        [Display(Name = "Изображение товара на глвной странице")]
        public string ProductImg { get; set; }

        [Display(Name = "Ссылка на товар")]
        public string LinkProduct { get; set; }

        [Display(Name = "Изображение на странице услуг")]
        public string ImgServiceList { get; set; }

        [Display(Name = "Заголовок на банере")]
        public string TitleBanner { get; set; }

        [Display(Name = "Подзаголовок на банере")]
        public string SubTitleBanner { get; set; }
    }
}
