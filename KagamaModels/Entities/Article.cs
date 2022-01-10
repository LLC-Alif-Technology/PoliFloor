using System;
using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Article
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        [Required(ErrorMessage = "Поле '{0}' обязательно")]
        public string Title { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Подзаголовок")]
        public string SubTitle { get; set; }

        [Display(Name = "На главную")]
        public bool IsMainPage { get; set; }

        [Display(Name = "Дата публикации")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Изображение")]
        public string Img { get; set; }

        [Display(Name = "Изображение на открытой статье")]
        public string ImgOpenPage { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Категория")]
        public int? CategoryId { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }

        [Display(Name = "Новость да/нет")]
        public bool IsNews { get; set; }
    }
}
