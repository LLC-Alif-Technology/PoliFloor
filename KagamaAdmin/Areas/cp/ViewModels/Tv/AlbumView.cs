using System.ComponentModel.DataAnnotations;

namespace KagamaAdmin.Areas.cp.ViewModels.Tv
{
    public class AlbumView
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Заголовок для альбома")]
        public string TitleAlbum { get; set; }

        [Display(Name = "Id альбома")]
        public int? AlbumId { get; set; }

        [Display(Name = "Ссылка на альбом")]
        public string LinkAlbum { get; set; }

        [Display(Name = "Описание")]
        public string Description2 { get; set; }
    }
}
