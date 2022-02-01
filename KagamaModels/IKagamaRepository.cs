using KagamaModels.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KagamaModels
{
    public interface IKagamaRepository
    {
        Task<AdminUser> GetAdminUser(string login, string password);

        #region Gallery

        void GalleryCategoryCreate(GalleryCategory model);

        IEnumerable<GalleryCategory> GalleryCategories();

        Task<IEnumerable<GalleryCategory>> GalleryCategoriesAsync();

        GalleryCategory GetGalleryCategory(int id);

        Task<GalleryCategory> GetGalleryCategoryAsync(string alias);

        void GalleryCategoryEdit(GalleryCategory model);

        void GalleryCategoryDelete(GalleryCategory model);

        void GalleryAlbumCreate(GalleryAlbum model);

        IEnumerable<GalleryAlbum> GalleryAlbums();

        Task<IEnumerable<GalleryAlbum>> GalleryAlbumsAsync();

        Task<IEnumerable<GalleryAlbum>> GetGalleryAlbumsAsync(uint galleryCategoryId);

        GalleryAlbum GetGalleryAlbum(int id);

        Task<GalleryAlbum> GetGalleryAlbumAsync(string alias);

        Task<GalleryAlbum> GetGalleryAlbumAsyncAll(string alias);

        void GalleryAlbumEdit(GalleryAlbum model);

        void GalleryAlbumDelete(GalleryAlbum model);

        int GalleryItemCreate(GalleryItem model);

        void GalleryRelationCreate(GalleryRelation model);

        IEnumerable<GalleryItem> GalleryItems();

        Task<IEnumerable<GalleryItem>> GalleryItemsAsync();

        GalleryItem GetGalleryItem(int id);

        Task<IEnumerable<GalleryItem>> GetGalleryItemAsync(int? albumId);

        Task<IEnumerable<GalleryItem>> GetGalleryItemTakeAsync(int? albumId);

        Task<IEnumerable<GalleryItem>> GetGalleryCategoryItemsAsync(int galleryCategoryId);

        Task<IEnumerable<GalleryItem>> GetGalleryCategoriesItemsAsync(IEnumerable<GalleryCategory> galleryCategories);

        void GalleryItemDelete(GalleryItem model);

        IEnumerable<GalleryRelation> GalleryRelations(int id);

        void GalleryRelationDelete(IEnumerable<GalleryRelation> galleryRelations);

        int[] GetGalleryRelations(int galleryItemId);

        void GalleryItemEdit(int id, string title, string icon);

        #endregion

        #region Service

        IEnumerable<Service> GetServices();

        Task<IEnumerable<Service>> GetServicesAsync();

        void ServiceCreate(string title, string titleH1, string titleH2, string titleH3, string bannerLink, string bannerLinkName, string alias, string description1, string imgServicePage, int? sortHeader);

        Service GetService(int id);

        Task<Service> GetServiceAsync(string alias);

        void ServiceEdit(int id, string title, string titleH1, string titleH2, string titleH3, string bannerLink, string bannerLinkName, string alias, string description1, string imgServicePage, int? sortHeader);

        void MainPageEdit(int id, string titleBanner, string subTitleBanner, string linkProduct, string banner,
            string thumb, string imgServiceList, string productImg);

        void ServiceAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description);

        void ServiceVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description);

        void ServiceSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void ServiceProduct(int id, string titleProducts, string description);

        void AddProductForService(int serId, int prodId);

        IEnumerable<ServiceProduct> GetServiceProducts(int id);

        Task<IEnumerable<Product>> GetServiceProductsAsync(int id);

        Task<IEnumerable<Project>> GetServiceProjectsAsync(int id);

        Task<IEnumerable<Floor>> GetServiceFloorsAsync(int id);

        Task<IEnumerable<Article>> GetServiceQuestionsAsync(int id);

        ServiceProduct GetServiceProduct(int productId, int serviceId);

        void ServiceProductDelete(ServiceProduct model);

        void ServiceSchema(int id, string titleSchema, string description);

        void ServiceCalc(int id, string titleCalc, string description, int? calcId);

        void ServiceObject(int id, string titleObject, string description);

        void ServiceArea(int id, string titleOblast, string description);

        void ServiceQuestion(int id, string titleQuestion, string description);

        IEnumerable<ServiceProject> GetServiceProjects(int id);

        void AddProjectForService(int serId, int projId);

        void ServiceProjectDelete(ServiceProject model);

        ServiceProject GetServiceProject(int projectId, int serviceId);

        IEnumerable<ServiceFloor> GetServiceFloors(int id);

        void AddFloorForService(int serId, int floorId);

        ServiceFloor GetServiceFloor(int floorId, int serviceId);

        void ServiceFloorDelete(ServiceFloor model);

        void AddQuestionForService(int serId, int artId);

        ServiceQuestion GetServiceQuestion(int artId, int serviceId);

        IEnumerable<ServiceQuestion> GetServiceQuestions(int id);

        void ServiceQuestionDelete(ServiceQuestion model);

        void ServiceDeleteAllMaterials(int id);

        void ServiceDeleteAllProjects(int id);

        void ServiceDeleteAllFloors(int id);

        void ServiceDeleteAllQuestions(int id);

        void ServiceDelete(Service service);

        #endregion

        #region Product

        EurCourse GetEurCourse(string name);

        void UpdateEur(decimal eur);

        IEnumerable<Product> GetProducts();

        Task<IEnumerable<Product>> GetProductsAsync();

        Task<IEnumerable<Product>> GetProductsTakeAsync();

        Task<IEnumerable<Product>> GetProductsAsync(int catId);

        IEnumerable<ProductCategory> ProductCategories();

        Task<IEnumerable<ProductCategory>> ProductCategoriesAsync();

        ProductCategory GetProductCategory(int id);

        Task<ProductCategory> GetProductCategoryAsync(string alias);

        void ProductCategoryCreate(ProductCategory model);

        void ProductCategoryEdit(ProductCategory model);

        void ProductCategoryDelete(ProductCategory model);

        Product GetProduct(int id);

        Task<Product> GetProductAsync(int id);

        Task<Product> GetProductOpenAsync(string alias);

        void ProductCreate(Product model);

        void ProductEdit(Product model);

        void ProductDelete(Product model);

        void ProductImage(int id, string img1, string img2, string img3);
        void AddReview(Review review);

        void ProductSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void ProductBuy(int productId, int id);

        IEnumerable<ProductBuy> GetProductBuys(int id);

        Task<IEnumerable<Product>> GetProductBuysAsync(int id);

        ProductBuy GetProductBuy(int thisId, int productId);

        void ProductBuyDelete(ProductBuy model);

        void ProductBuyDeleteAll(int id);

        #endregion

        #region Project

        IEnumerable<Project> GetProjects();

        Task<IEnumerable<Project>> GetMainProjectsAsync();

        Task<IEnumerable<Project>> GetProjectsAsync();

        void ProjectCreate(string title, string alias, string titleH1, string square, string city, decimal? price);

        Project GetProject(int id);

        Task<Project> GetProjectAsync(string alias);

        void ProjectEdit(int id, string title, string titleH1, string alias, string square, string city, decimal? price);

        void ProjectImageEdit(int id, string img, string banner);

        void ProjectAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description);

        void ProjectVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description);

        void ProjectSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void ProjectDelete(Project project);

        #endregion

        #region Floor

        IEnumerable<Floor> GetFloors();

        Task<IEnumerable<Floor>> GetFloorsAsync();

        Task<Floor> GetFloorAsync(string alias);

        void FloorCreate(string title, string titleH1, string alias, string description, string icon);

        Floor GetFloor(int id);

        void FloorEdit(int id, string title, string titleH1, string alias, string description, string icon);

        void FloorAlbum(int id, string titleAlbum, int albumId, string linkAlbum, string description);

        void FloorSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void FloorProduct(int id, string titleProducts, string description);

        void AddProductForFloor(int floorId, int prodId);

        IEnumerable<FloorProduct> GetFloorProducts(int id);

        FloorProduct GetFloorProduct(int productId, int floorId);

        void FloorProductDelete(FloorProduct model);

        Task<IEnumerable<Product>> GetFloorProductsAsync(int floorId);

        void FloorQuestion(int id, string titleQuestion, string description);

        void AddQuestionForFloor(int floorId, int artId);

        void FloorQuestionDelete(FloorQuestion model);

        IEnumerable<FloorQuestion> GetFloorQuestions(int id);

        Task<IEnumerable<Article>> GetFloorQuestionsAsync(int floorId);

        FloorQuestion GetFloorQuestion(int artId, int floorId);

        void FloorDeleteAllMaterials(int id);

        void FloorDeleteAllQuestions(int id);

        void FloorDelete(Floor floor);

        #endregion

        #region Article

        IEnumerable<Article> GetArticles();

        Task<IEnumerable<Article>> GetMainQuestionsAsync();

        Task<IEnumerable<Article>> GetMainNewsAsync();

        Task<IEnumerable<Article>> GetNewsAsync();

        Task<IEnumerable<Article>> GetArticlesAsync();

        Task<IEnumerable<Article>> GetNewsAsync(int? catId);

        Task<IEnumerable<Article>> GetArticleAsync(int? catId);

        Task<IEnumerable<Article>> GetNewsTakeAsync();

        Task<IEnumerable<Article>> GetArticlesTakeAsync();

        IEnumerable<ArticleCategory> ArticleCategories();

        Task<IEnumerable<ArticleCategory>> ArticleCategoriesAsync();

        Task<IEnumerable<ArticleCategory>> NewsCategoriesAsync();

        ArticleCategory GetArticleCategory(int id);

        Task<ArticleCategory> GetNewsCategoryAsync(string alias);

        Task<ArticleCategory> GetArticleCategoryAsync(string alias);

        void ArticleCategoryCreate(ArticleCategory model);

        void ArticleCategoryEdit(ArticleCategory model);

        void ArticleCategoryDelete(ArticleCategory model);

        Article GetArticle(int id);

        Task<Article> GetNewsOpenAsync(string alias);

        Task<Article> GetArticleOpenAsync(string alias);

        void ArticleCreate(Article model);

        void ArticleEdit(Article model);

        void ArticleDelete(Article model);

        void ArticleImage(int id, string img, string imgOpenPage);

        void ArticleSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        #endregion

        #region Tv

        IEnumerable<Tv> GetTvs();

        Task<IEnumerable<Tv>> GetTvsAsync();

        Task<IEnumerable<Tv>> GetObuchenieListAsync();

        void TvCreate(string icon, string banner, string caption, string title, string subTitle, string titleH1,
            string alias, string description, bool isTv);

        Tv GetTv(int id);

        Task<Tv> GetTvAsync(string alias);

        void TvEdit(int id, string icon, string banner, string caption, string title, string subTitle, string titleH1,
            string alias, string description, bool isTv);

        void TvAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description);

        void TvVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description);

        void TvSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void TvDelete(Tv tv);

        #endregion

        #region Video

        IEnumerable<Video> GetVideos();

        Task<IEnumerable<Video>> GetVideosAsync();

        Task<IEnumerable<Video>> GetMainVideosAsync();

        Task<IEnumerable<Video>> GetVideoAsync(int? catId);

        Task<IEnumerable<Video>> GetVideosTakeAsync();

        void VideoCreate(string title, string titleH1, string alias, string description, string thumb, string banner,
            string linkVideo, int? catId);

        Video GetVideo(int id);

        Task<Video> GetVideoOpenAsync(string alias);

        void VideoEdit(int id, string title, string titleH1, string alias, string description, string thumb,
            string banner, string linkVideo, int? catId);

        void VideoSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void VideoDelete(Video video);

        IEnumerable<VideoCategory> VideoCategories();

        Task<IEnumerable<VideoCategory>> VideoCategoriesAsync();

        VideoCategory GetVideoCategory(int id);

        Task<VideoCategory> GetVideoCategoryAsync(string alias);

        void VideoCategoryCreate(VideoCategory model);

        void VideoCategoryEdit(VideoCategory model);

        void VideoCategoryDelete(VideoCategory model);

        #endregion

        #region Region

        IEnumerable<Region> GetRegions();

        Task<IEnumerable<RegionCategory>> GetRegionsCategoryAsync();

        Task<IEnumerable<Region>> GetRegionsAsync();

        IEnumerable<RegionCategory> RegionCategories();

        RegionCategory GetRegionCategory(int id);

        void RegionCategoryCreate(RegionCategory model);

        void RegionCategoryEdit(RegionCategory model);

        void RegionCategoryDelete(RegionCategory model);

        Region GetRegion(int id);

        Task<Region> GetRegionAsync(string alias);

        void RegionCreate(Region model);

        void RegionEdit(Region model);

        void RegionDelete(Region model);

        void RegionSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        void RegionAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description);

        void RegionVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description);

        void AddProductForRegion(int regionId, int prodId);

        void RegionProduct(int id, string titleProducts, string description);

        IEnumerable<RegionProduct> GetRegionProducts(int id);

        RegionProduct GetRegionProduct(int productId, int regionId);

        void RegionProductDelete(RegionProduct model);

        void RegionDeleteAllMaterials(int id);

        Task<IEnumerable<Product>> GetRegionProductsAsync(int id);

        #endregion

        #region Contacts

        IEnumerable<Contact> GetContacts();

        Task<IEnumerable<Contact>> GetContactsAsync();

        Contact GetContact(int id);

        Task<Contact> GetMainContactAsync();

        void ContactCreate(Contact model);

        void ContactEdit(Contact model);

        void ContactDelete(Contact model);

        #endregion

        #region Page

        IEnumerable<Page> GetPages();

        Page GetPage(int id);

        Task<Page> GetPageAsync(string alias);

        void PageCreate(Page model);

        void PageEdit(Page model);

        void PageDelete(Page model);

        void PageSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        #endregion

        #region Counter

        IEnumerable<Counter> Counters();

        Task<IEnumerable<Counter>> CountersAsync();

        Counter GetCounter(int id);

        void CounterCreate(Counter counter);

        void CounterDelete(Counter counter);

        void CounterEdit(Counter model);

        #endregion

        #region Calc

        void CalcCategoryCreate(CalcCategory model);

        IEnumerable<CalcCategory> CalcCategories();

        CalcCategory GetCalcCategory(int id);

        CalcCategory GetCalcCategoryAlias(string alias);

        void CalcCategoryEdit(CalcCategory model);

        void CalcThickCreate(int id, int mm, string comment);

        IEnumerable<CalcThick> CalcThicks(int id);

        void CalcThickDelete(CalcThick model);

        CalcThick GetCalcThick(int id);

        void CalcProductCreate(int productId, int id, bool glossy, bool semiMatt, bool matt, bool smooth, bool grungy, string kg);

        IEnumerable<CalcProduct> CalcProducts(int id);

        IEnumerable<CalcProduct> CalcProductsFilter(int id, string varnish, string surface);

        CalcProduct GetCalcProduct(int id);

        void CalcProductDelete(CalcProduct model);

        void CalcProductEdit(int productId, int id, bool glossy, bool semiMatt, bool matt, bool smooth, bool grungy, string kg, int thisId);

        void CalcCategoryDelete(CalcCategory model);

        void CalcSeo(int id, string seoTitle, string seoKeywords, string seoDescription);

        #endregion
        
        #region Review
        void ReviewCreat(Review model);
        
        Task<List<Review>> GetAllReview();

        Task<List<Tv>> GetAllTv();
        Task<List<Service>> GetAllServices();
        Task<Review> GetReviewById(int Id);
        Task<List<Review>> GetOnlyFalseReview();
        Review ReviewGet(int id);

        #endregion

    }
}
