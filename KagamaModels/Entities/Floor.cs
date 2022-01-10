using System.ComponentModel.DataAnnotations;

namespace KagamaModels.Entities
{
    public class Floor
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Display(Name = "Иконка")]
        public string Icon { get; set; }

        [Display(Name = "Заголовок h1")]
        public string TitleH1 { get; set; }

        [Display(Name = "Url")]
        public string Alias { get; set; }

        [Display(Name = "Описание ck_editor1")]
        public string Description1 { get; set; }

        [Display(Name = "Заголовок для альбома")]
        public string TitleAlbum { get; set; }

        [Display(Name = "Id альбома")]
        public int AlbumId { get; set; }

        [Display(Name = "Ссылка на альбом")]
        public string LinkAlbum { get; set; }

        [Display(Name = "Описание ck_editor2")]
        public string Description2 { get; set; }

        [Display(Name = "Заголовок для материалов")]
        public string TitleProducts { get; set; }

        [Display(Name = "Описание ck_editor3")]
        public string Description3 { get; set; }

        [Display(Name = "Заголовок для популярных вопросов")]
        public string TitleQuestion { get; set; }

        [Display(Name = "Описание ck_editor4")]
        public string Description4 { get; set; }

        [Display(Name = "SeoTitle")]
        public string SeoTitle { get; set; }

        [Display(Name = "SeoDescription")]
        public string SeoDescription { get; set; }

        [Display(Name = "SeoKeywords")]
        public string SeoKeywords { get; set; }
    }
}
