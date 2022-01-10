namespace KagamaModels.Entities
{
    public class GalleryRelation
    {
        public int Id { get; set; }

        public int GalleryItemId { get; set; }

        public int GalleryAlbumId { get; set; }

        public uint GalleryCategoryId { get; set; }
    }
}
