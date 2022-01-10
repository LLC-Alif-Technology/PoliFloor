using KagamaModels.Entities;
using Microsoft.EntityFrameworkCore;

namespace KagamaModels
{
    public class EFDBContext : DbContext
    {
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<GalleryCategory> GalleryCategories { get; set; }
        public DbSet<GalleryAlbum> GalleryAlbums { get; set; }
        public DbSet<GalleryItem> GalleryItems { get; set; }
        public DbSet<GalleryRelation> GalleryRelations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductBuy> ProductBuys { get; set; }
        public DbSet<ServiceProduct> ServiceProducts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ServiceProject> ServiceProjects { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<FloorProduct> FloorProducts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<FloorQuestion> FloorQuestions { get; set; }
        public DbSet<ServiceFloor> ServiceFloors { get; set; }
        public DbSet<ServiceQuestion> ServiceQuestions { get; set; }
        public DbSet<Tv> Tvs { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoCategory> VideoCategories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionCategory> RegionCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<RegionProduct> RegionProducts { get; set; }
        public DbSet<CalcCategory> CalcCategories { get; set; }
        public DbSet<CalcThick> CalcThicks { get; set; }
        public DbSet<CalcProduct> CalcProducts { get; set; }
        public DbSet<EurCourse> EurCourses { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
