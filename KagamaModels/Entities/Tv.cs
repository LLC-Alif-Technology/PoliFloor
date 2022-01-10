using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KagamaModels.Entities
{
    public class Tv
    {
        public int Id { get; set; }

        [Display(Name = "Иконка")]
        public string Icon { get; set; }

        [Display(Name = "Банер")]
        public string Banner { get; set; }

        [Display(Name = "Надпись над заголовком")]
        public string Caption { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "ПодЗаголовок")]
        public string SubTitle { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Мы на тв / Обучение -  да/нет")]
        public bool IsTv { get; set; }

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

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
