using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Service
    {
        public int Id { get; set; }

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

        [Display(Name = "Изображение на странице открытой услуги")]
        public string ImgServicePage { get; set; }

        [Display(Name = "Заголовок")]
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

        [Display(Name = "Заголовок на банере")]
        public string TitleBanner { get; set; }

        [Display(Name = "Подзаголовок на банере")]
        public string SubTitleBanner { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание ck_editor1")]
        public string Description1 { get; set; }

        [Display(Name = "Заголовок для альбома")]
        public string TitleAlbum { get; set; }

        [Display(Name = "Id альбома")]
        public int? AlbumId { get; set; }

        [Display(Name = "Ссылка на альбом")]
        public string LinkAlbum { get; set; }

        [Display(Name = "Описание ck_editor2")]
        public string Description2 { get; set; }

        [Display(Name = "Заголовок для видео")]
        public string TitleVideo { get; set; }

        [Display(Name = "Ссылка для видео")]
        public string LinkVideo { get; set; }

        [Display(Name = "Превью для видео")]
        public string PreviewVideo { get; set; }

        [Display(Name = "Описание ck_editor3")]
        public string Description3 { get; set; }

        [Display(Name = "Заголовок для продуктов")]
        public string TitleProducts { get; set; }

        [Display(Name = "Описание ck_editor4")]
        public string Description4 { get; set; }

        [Display(Name = "Заголовок для взрыв схемы")]
        public string TitleSchema { get; set; }

        [Display(Name = "Код схемы")]
        public string SchemaCode { get; set; }

        [Display(Name = "Описание ck_editor5")]
        public string Description5 { get; set; }

        [Display(Name = "Заголовок для калькулятора")]
        public string TitleCalc { get; set; }

        [Display(Name = "Id калькулятора")]
        public int? CalcId { get; set; }

        [Display(Name = "Описание ck_editor6")]
        public string Description6 { get; set; }

        [Display(Name = "Заголовок для готовых объектов")]
        public string TitleObject { get; set; }

        [Display(Name = "Описание ck_editor7")]
        public string Description7 { get; set; }

        [Display(Name = "Заголовок для области применения")]
        public string TitleOblast { get; set; }

        [Display(Name = "Описание ck_editor8")]
        public string Description8 { get; set; }

        [Display(Name = "Заголовок для популярных вопросов")]
        public string TitleQuestion { get; set; }

        [Display(Name = "Описание ck_editor9")]
        public string Description9 { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }

        [Display(Name = "Сортировка услуг в шапке ")]
        public int? SortHeader { get; set; }

        public string Hide { get; set; }
    }
}
