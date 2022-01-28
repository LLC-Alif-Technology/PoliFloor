using KagamaModels.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KagamaModels
{
    public class MsSqlDataService : IKagamaRepository
    {
        private EFDBContext _dbContext;

        public MsSqlDataService(EFDBContext context)
        {
            _dbContext = context;
        }

        public async Task<AdminUser> GetAdminUser(string login, string password) =>
            await _dbContext.AdminUsers.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);

        #region Gallery

        public void GalleryCategoryCreate(GalleryCategory model)
        {
            _dbContext.GalleryCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GalleryCategory> GalleryCategories() => _dbContext.GalleryCategories;

        public async Task<IEnumerable<GalleryCategory>> GalleryCategoriesAsync() =>
            await _dbContext.GalleryCategories.Where(x => x.Show).ToListAsync();

        public GalleryCategory GetGalleryCategory(int id) =>
            _dbContext.GalleryCategories.SingleOrDefault(x => x.Id == id);

        public async Task<GalleryCategory> GetGalleryCategoryAsync(string alias) =>
            await _dbContext.GalleryCategories.Where(x => x.Show).SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void GalleryCategoryEdit(GalleryCategory model)
        {
            GalleryCategory galleryCategory = GetGalleryCategory(model.Id);

            if (galleryCategory != null)
            {
                galleryCategory.Icon = model.Icon;
                galleryCategory.Title = model.Title;
                galleryCategory.TitleH1 = model.TitleH1;
                galleryCategory.Alias = model.Alias;
                galleryCategory.Show = model.Show;
                galleryCategory.SeoTitle = model.SeoTitle;
                galleryCategory.SeoKeywords = model.SeoKeywords;
                galleryCategory.SeoDescription = model.SeoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void GalleryCategoryDelete(GalleryCategory model)
        {
            _dbContext.GalleryCategories.Remove(model);
            _dbContext.SaveChanges();
        }

        public void GalleryAlbumCreate(GalleryAlbum model)
        {
            _dbContext.GalleryAlbums.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GalleryAlbum> GalleryAlbums() => _dbContext.GalleryAlbums;

        public async Task<IEnumerable<GalleryAlbum>> GalleryAlbumsAsync() =>
            await _dbContext.GalleryAlbums.Where(x => x.Show).ToListAsync();

        public async Task<IEnumerable<GalleryAlbum>> GetGalleryAlbumsAsync(uint galleryCategoryId) =>
            await _dbContext.GalleryAlbums.Where(x => x.Show && x.GalleryCategoryId == galleryCategoryId).ToListAsync();

        public GalleryAlbum GetGalleryAlbum(int id) => _dbContext.GalleryAlbums.SingleOrDefault(x => x.Id == id);

        public async Task<GalleryAlbum> GetGalleryAlbumAsync(string alias) =>
            await _dbContext.GalleryAlbums.Where(x => x.Show).SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public async Task<GalleryAlbum> GetGalleryAlbumAsyncAll(string alias) =>
            await _dbContext.GalleryAlbums.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void GalleryAlbumEdit(GalleryAlbum model)
        {
            GalleryAlbum galleryAlbum = GetGalleryAlbum(model.Id);

            if (galleryAlbum != null)
            {
                galleryAlbum.Title = model.Title;
                galleryAlbum.TitleH1 = model.TitleH1;
                galleryAlbum.Alias = model.Alias;
                galleryAlbum.Show = model.Show;
                galleryAlbum.GalleryCategoryId = model.GalleryCategoryId;
                galleryAlbum.Description = model.Description;
                galleryAlbum.SeoTitle = model.SeoTitle;
                galleryAlbum.SeoKeywords = model.SeoKeywords;
                galleryAlbum.SeoDescription = model.SeoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void GalleryAlbumDelete(GalleryAlbum model)
        {
            _dbContext.GalleryAlbums.Remove(model);
            _dbContext.SaveChanges();
        }

        public int GalleryItemCreate(GalleryItem model)
        {
            _dbContext.GalleryItems.Add(model);
            _dbContext.SaveChanges();

            return model.Id;
        }

        public void GalleryRelationCreate(GalleryRelation model)
        {
            _dbContext.GalleryRelations.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GalleryItem> GalleryItems() => _dbContext.GalleryItems.OrderByDescending(x => x.Id);

        public async Task<IEnumerable<GalleryItem>> GalleryItemsAsync() => await _dbContext.GalleryItems.ToListAsync();

        public GalleryItem GetGalleryItem(int id) => _dbContext.GalleryItems.SingleOrDefault(x => x.Id == id);

        public async Task<IEnumerable<GalleryItem>> GetGalleryItemAsync(int? albumId) =>
            await (from x in _dbContext.GalleryItems
                   join c in _dbContext.GalleryRelations.Where(x => x.GalleryAlbumId == albumId) on x.Id equals c
                       .GalleryItemId
                   select new GalleryItem
                   {
                       Title = x.Title,
                       Icon = x.Icon
                   }).ToListAsync();

        public async Task<IEnumerable<GalleryItem>> GetGalleryItemTakeAsync(int? albumId) =>
            await (from x in _dbContext.GalleryItems
                   join c in _dbContext.GalleryRelations.Where(x => x.GalleryAlbumId == albumId) on x.Id equals c
                       .GalleryItemId
                   select new GalleryItem
                   {
                       Title = x.Title,
                       Icon = x.Icon
                   }).Take(20).ToListAsync();

        public async Task<IEnumerable<GalleryItem>> GetGalleryCategoryItemsAsync(int galleryCategoryId) =>
            await (from x in _dbContext.GalleryItems
                   join c in _dbContext.GalleryRelations.Where(x => x.GalleryCategoryId == galleryCategoryId) on x.Id
                       equals c.GalleryItemId
                   group x by new
                   {
                       x.Title,
                       x.Icon
                   }
                into grp
                   select new GalleryItem
                   {
                       Title = grp.Key.Title,
                       Icon = grp.Key.Icon
                   }).ToListAsync();

        public async Task<IEnumerable<GalleryItem>> GetGalleryCategoriesItemsAsync(IEnumerable<GalleryCategory> galleryCategories)
        {
            //List<GalleryItem> galleryItems = new List<GalleryItem>();

            //foreach (var galleryCategory in galleryCategories)
            //{
            //    galleryItems.AddRange(await (from x in _dbContext.GalleryItems
            //        join c in _dbContext.GalleryRelations.Where(x => x.GalleryCategoryId == galleryCategory.Id) on x.Id equals c.GalleryItemId
            //        select new GalleryItem
            //        {
            //            Title = x.Title,
            //            Icon = x.Icon
            //        }).ToListAsync());
            //}

            //return galleryItems;

            var idList = galleryCategories.Select(y => y.Id).ToList();
            return await (from x in _dbContext.GalleryItems
                          join c in _dbContext.GalleryRelations.Where(x => idList.Contains((int)x.GalleryCategoryId)) on x.Id
                              equals c.GalleryItemId
                          group x by new
                          {
                              x.Title,
                              x.Icon
                          }
                into grp
                          select new GalleryItem
                          {
                              Title = grp.Key.Title,
                              Icon = grp.Key.Icon
                          }).ToListAsync();
        }

        public void GalleryItemDelete(GalleryItem model)
        {
            _dbContext.GalleryItems.Remove(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GalleryRelation> GalleryRelations(int id) =>
            _dbContext.GalleryRelations.Where(x => x.GalleryItemId == id);

        public void GalleryRelationDelete(IEnumerable<GalleryRelation> galleryRelations)
        {
            _dbContext.GalleryRelations.RemoveRange(galleryRelations);
            _dbContext.SaveChanges();
        }

        public int[] GetGalleryRelations(int galleryItemId) =>
            _dbContext.GalleryRelations.Where(x => x.GalleryItemId == galleryItemId).Select(x => x.GalleryAlbumId).ToArray();

        public void GalleryItemEdit(int id, string title, string icon)
        {
            GalleryItem galleryItem = GetGalleryItem(id);

            if (galleryItem != null)
            {
                galleryItem.Icon = icon;
                galleryItem.Title = title;
            }

            _dbContext.SaveChanges();
        }

        #endregion

        #region Service

        public IEnumerable<Service> GetServices() => _dbContext.Services;

        public async Task<IEnumerable<Service>> GetServicesAsync() => await _dbContext.Services.OrderBy(x => x.SortHeader).ToListAsync();

        public void ServiceCreate(string title, string titleH1, string titleH2, string titleH3, string bannerLink, string bannerLinkName, string alias, string description1, string imgServicePage, int? sortHeader)
        {
            Service service = new Service
            {
                Title = title,
                TitleH1 = titleH1,
                TitleH2 = titleH2,
                TitleH3 = titleH3,
                BannerLink = bannerLink,
                BannerLinkName = bannerLinkName,
                Alias = alias,
                Description1 = description1,
                ImgServicePage = imgServicePage,
                SortHeader = sortHeader,
            };

            _dbContext.Services.Add(service);
            _dbContext.SaveChanges();
        }

        public Service GetService(int id) => _dbContext.Services.SingleOrDefault(x => x.Id == id);

        public async Task<Service> GetServiceAsync(string alias) =>
            await _dbContext.Services.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ServiceEdit(int id, string title, string titleH1, string titleH2, string titleH3, string bannerLink, string bannerLinkName, string alias, string description1, string imgServicePage, int? sortHeader)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.Title = title;
                service.TitleH1 = titleH1;
                service.TitleH2 = titleH2;
                service.TitleH3 = titleH3;
                service.BannerLink = bannerLink;
                service.BannerLinkName = bannerLinkName;
                service.Alias = alias;
                service.Description1 = description1;
                service.ImgServicePage = imgServicePage;
                service.SortHeader = sortHeader;
            }

            _dbContext.SaveChanges();
        }

        public void MainPageEdit(int id, string titleBanner, string subTitleBanner, string linkProduct, string banner,
            string thumb, string imgServiceList, string productImg)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleBanner = titleBanner;
                service.SubTitleBanner = subTitleBanner;
                service.LinkProduct = linkProduct;
                service.Banner = banner;
                service.Thumb = thumb;
                service.ImgServiceList = imgServiceList;
                service.ProductImg = productImg;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleAlbum = titleAlbum;
                service.AlbumId = albumId;
                service.LinkAlbum = linkAlbum;
                service.Description2 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleVideo = titleVideo;
                service.LinkVideo = linkVideo;
                service.PreviewVideo = previewVideo;
                service.Description3 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.SeoTitle = seoTitle;
                service.SeoKeywords = seoKeywords;
                service.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceProduct(int id, string titleProducts, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleProducts = titleProducts;
                service.Description4 = description;
            }

            _dbContext.SaveChanges();
        }

        public void AddProductForService(int serId, int prodId)
        {
            ServiceProduct serviceProduct = new ServiceProduct
            {
                ServiceId = serId,
                ProductId = prodId
            };

            _dbContext.ServiceProducts.Add(serviceProduct);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ServiceProduct> GetServiceProducts(int id) =>
            _dbContext.ServiceProducts.Where(x => x.ServiceId == id);

        public ServiceProduct GetServiceProduct(int productId, int serviceId) =>
            _dbContext.ServiceProducts.FirstOrDefault(x => x.ProductId == productId && x.ServiceId == serviceId);

        public void ServiceProductDelete(ServiceProduct model)
        {
            _dbContext.ServiceProducts.Remove(model);
            _dbContext.SaveChanges();
        }

        public void ServiceSchema(int id, string titleSchema, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleSchema = titleSchema;
                service.Description5 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceCalc(int id, string titleCalc, string description, int? calcId)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleCalc = titleCalc;
                service.Description6 = description;
                service.CalcId = calcId;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceObject(int id, string titleObject, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleObject = titleObject;
                service.Description7 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceArea(int id, string titleOblast, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleOblast = titleOblast;
                service.Description8 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ServiceQuestion(int id, string titleQuestion, string description)
        {
            Service service = GetService(id);

            if (service != null)
            {
                service.TitleQuestion = titleQuestion;
                service.Description9 = description;
            }

            _dbContext.SaveChanges();
        }

        public IEnumerable<ServiceProject> GetServiceProjects(int id) =>
            _dbContext.ServiceProjects.Where(x => x.ServiceId == id);

        public async Task<IEnumerable<Product>> GetServiceProductsAsync(int id)
        {
            return await (from x in _dbContext.Products
                          join c in _dbContext.ServiceProducts.Where(x => x.ServiceId == id) on x.Id equals c.ProductId
                          select new Product
                          {
                              Id = x.Id,
                              Title = x.Title,
                              SubTitle = x.SubTitle,
                              Alias = x.Alias,
                              Img1 = x.Img1,
                              PriceKg = x.PriceKg,
                              PriceKit = x.PriceKit,
                              Stock = x.Stock
                          }).ToListAsync();
        }

        public async Task<IEnumerable<Project>> GetServiceProjectsAsync(int id)
        {
            return await (from x in _dbContext.Projects
                          join c in _dbContext.ServiceProjects.Where(x => x.ServiceId == id) on x.Id equals c.ProjectId
                          select new Project
                          {
                              Alias = x.Alias,
                              Img = x.Img,
                              City = x.City,
                              Square = x.Square,
                              Title = x.Title
                          }).ToListAsync();
        }

        public async Task<IEnumerable<Floor>> GetServiceFloorsAsync(int id)
        {
            return await (from x in _dbContext.Floors
                          join c in _dbContext.ServiceFloors.Where(x => x.ServiceId == id) on x.Id equals c.FloorId
                          select new Floor
                          {
                              Alias = x.Alias,
                              Title = x.Title,
                              Icon = x.Icon

                          }).ToListAsync();
        }

        public async Task<IEnumerable<Article>> GetServiceQuestionsAsync(int id)
        {
            return await (from x in _dbContext.Articles
                          join c in _dbContext.ServiceQuestions.Where(x => x.ServiceId == id) on x.Id equals c.ArticleId
                          select new Article
                          {
                              Alias = x.Alias,
                              Title = x.Title,
                              SubTitle = x.SubTitle,
                              CreationDate = x.CreationDate
                          }).ToListAsync();
        }

        public void AddProjectForService(int serId, int projId)
        {
            ServiceProject serviceProject = new ServiceProject
            {
                ServiceId = serId,
                ProjectId = projId
            };

            _dbContext.ServiceProjects.Add(serviceProject);
            _dbContext.SaveChanges();
        }

        public void ServiceProjectDelete(ServiceProject model)
        {
            _dbContext.ServiceProjects.Remove(model);
            _dbContext.SaveChanges();
        }

        public ServiceProject GetServiceProject(int projectId, int serviceId) =>
            _dbContext.ServiceProjects.FirstOrDefault(x => x.ProjectId == projectId && x.ServiceId == serviceId);

        public IEnumerable<ServiceFloor> GetServiceFloors(int id) =>
            _dbContext.ServiceFloors.Where(x => x.ServiceId == id);

        public void AddFloorForService(int serId, int floorId)
        {
            ServiceFloor serviceFloor = new ServiceFloor
            {
                ServiceId = serId,
                FloorId = floorId
            };

            _dbContext.ServiceFloors.Add(serviceFloor);
            _dbContext.SaveChanges();
        }

        public ServiceFloor GetServiceFloor(int floorId, int serviceId) =>
            _dbContext.ServiceFloors.FirstOrDefault(x => x.FloorId == floorId && x.ServiceId == serviceId);

        public void ServiceFloorDelete(ServiceFloor model)
        {
            _dbContext.ServiceFloors.Remove(model);
            _dbContext.SaveChanges();
        }

        public void AddQuestionForService(int serId, int artId)
        {
            ServiceQuestion serviceQuestion = new ServiceQuestion
            {
                ServiceId = serId,
                ArticleId = artId
            };

            _dbContext.ServiceQuestions.Add(serviceQuestion);
            _dbContext.SaveChanges();
        }

        public ServiceQuestion GetServiceQuestion(int artId, int serviceId) =>
            _dbContext.ServiceQuestions.FirstOrDefault(x => x.ArticleId == artId && x.ServiceId == serviceId);

        public IEnumerable<ServiceQuestion> GetServiceQuestions(int id) =>
            _dbContext.ServiceQuestions.Where(x => x.ServiceId == id);

        public void ServiceQuestionDelete(ServiceQuestion model)
        {
            _dbContext.ServiceQuestions.Remove(model);
            _dbContext.SaveChanges();
        }

        public void ServiceDeleteAllMaterials(int id)
        {
            _dbContext.ServiceProducts.RemoveRange(GetServiceProducts(id));
            _dbContext.SaveChanges();
        }

        public void ServiceDeleteAllProjects(int id)
        {
            _dbContext.ServiceProjects.RemoveRange(GetServiceProjects(id));
            _dbContext.SaveChanges();
        }

        public void ServiceDeleteAllFloors(int id)
        {
            _dbContext.ServiceFloors.RemoveRange(GetServiceFloors(id));
            _dbContext.SaveChanges();
        }

        public void ServiceDeleteAllQuestions(int id)
        {
            _dbContext.ServiceQuestions.RemoveRange(GetServiceQuestions(id));
            _dbContext.SaveChanges();
        }

        public void ServiceDelete(Service service)
        {
            _dbContext.Services.Remove(service);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Product

        public EurCourse GetEurCourse(string name) => _dbContext.EurCourses.FirstOrDefault(x => x.Name == name);

        public void UpdateEur(decimal eur)
        {
            EurCourse model = GetEurCourse("eur");

            if (model != null)
            {
                model.Course = eur;
            }

            _dbContext.SaveChanges();
        }

        public IEnumerable<Product> GetProducts() => _dbContext.Products;

        public async Task<IEnumerable<Product>> GetProductsAsync() => await _dbContext.Products.ToListAsync();

        public async Task<IEnumerable<Product>> GetProductsTakeAsync() => await _dbContext.Products.Take(4).ToListAsync();

        public async Task<IEnumerable<Product>> GetProductsAsync(int catId) =>
            await _dbContext.Products.Where(x => x.ProductCategoryId == catId).ToListAsync();

        public IEnumerable<ProductCategory> ProductCategories() => _dbContext.ProductCategories;

        public async Task<IEnumerable<ProductCategory>> ProductCategoriesAsync() =>
            await _dbContext.ProductCategories.ToListAsync();

        public ProductCategory GetProductCategory(int id) =>
            _dbContext.ProductCategories.SingleOrDefault(x => x.Id == id);

        public async Task<ProductCategory> GetProductCategoryAsync(string alias) =>
            await _dbContext.ProductCategories.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ProductCategoryCreate(ProductCategory model)
        {
            _dbContext.ProductCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public void ProductCategoryEdit(ProductCategory model)
        {
            ProductCategory productCategory = GetProductCategory(model.Id);

            if (productCategory != null)
            {
                productCategory.Title = model.Title;
                productCategory.TitleH1 = model.TitleH1;
                productCategory.Alias = model.Alias;
                productCategory.Desc = model.Desc;
                productCategory.SeoTitle = model.SeoTitle;
                productCategory.SeoKeywords = model.SeoKeywords;
                productCategory.SeoDescription = model.SeoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ProductCategoryDelete(ProductCategory model)
        {
            _dbContext.ProductCategories.Remove(model);
            _dbContext.SaveChanges();
        }

        public Product GetProduct(int id) =>
            _dbContext.Products.SingleOrDefault(x => x.Id == id);

        public async Task<Product> GetProductAsync(int id) =>
            await _dbContext.Products.SingleOrDefaultAsync(x => x.Id == id);

        public async Task<Product> GetProductOpenAsync(string alias) =>
            await _dbContext.Products.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ProductCreate(Product model)
        {
            _dbContext.Products.Add(model);
            _dbContext.SaveChanges();
        }

        public void ProductEdit(Product model)
        {
            Product product = GetProduct(model.Id);

            if (product != null)
            {
                product.Title = model.Title;
                product.Alias = model.Alias;
                product.SubTitle = model.SubTitle;
                product.Stock = model.Stock;
                product.PriceKg = model.PriceKg;
                product.PriceKit = model.PriceKit;
                product.LinkVideo = model.LinkVideo;
                product.ProductCategoryId = model.ProductCategoryId;
                product.Desc1 = model.Desc1;
                product.Desc2 = model.Desc2;
                product.Desc3 = model.Desc3;
                product.Desc4 = model.Desc4;
                product.Desc5 = model.Desc5;
                product.Desc6 = model.Desc6;
                product.Pdf = model.Pdf;
            }

            _dbContext.SaveChanges();
        }

        public void ProductDelete(Product model)
        {
            _dbContext.Products.Remove(model);
            _dbContext.SaveChanges();
        }

        public void ProductImage(int id, string img1, string img2, string img3)
        {
            Product product = GetProduct(id);

            if (product != null)
            {
                product.Img1 = img1;
                product.Img2 = img2;
                product.Img3 = img3;
            }

            _dbContext.SaveChanges();
        }

        public void AddReview(Review review)
        {
            _dbContext.Reviews.Add(review);
            _dbContext.SaveChanges();
        }

        private Review GetReview(int id)
        {
            return _dbContext.Reviews.Find(id);
        }

        public void ProductSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Product product = GetProduct(id);

            if (product != null)
            {
                product.SeoTitle = seoTitle;
                product.SeoKeywords = seoKeywords;
                product.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ProductBuy(int productId, int id)
        {
            Product product = GetProduct(id);

            if (product != null)
            {
                ProductBuy model = new ProductBuy
                {
                    ProductId = productId,
                    ThisProductId = id
                };

                _dbContext.ProductBuys.Add(model);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<ProductBuy> GetProductBuys(int id) =>
            _dbContext.ProductBuys.Where(x => x.ThisProductId == id);

        public async Task<IEnumerable<Product>> GetProductBuysAsync(int id)
        {
            return await (from x in _dbContext.Products
                          join c in _dbContext.ProductBuys.Where(x => x.ThisProductId == id) on x.Id equals c.ProductId
                          select new Product
                          {
                              Id = x.Id,
                              Title = x.Title,
                              SubTitle = x.SubTitle,
                              Alias = x.Alias,
                              Img1 = x.Img1,
                              PriceKg = x.PriceKg,
                              PriceKit = x.PriceKit,
                              Stock = x.Stock
                          }).ToListAsync();
        }

        public ProductBuy GetProductBuy(int thisId, int productId) =>
            _dbContext.ProductBuys.FirstOrDefault(x => x.ThisProductId == thisId && x.ProductId == productId);

        public void ProductBuyDelete(ProductBuy model)
        {
            _dbContext.ProductBuys.Remove(model);
            _dbContext.SaveChanges();
        }

        public void ProductBuyDeleteAll(int id)
        {
            _dbContext.ProductBuys.RemoveRange(GetProductBuys(id));
            _dbContext.SaveChanges();
        }

        #endregion

        #region Project

        public IEnumerable<Project> GetProjects() => _dbContext.Projects;

        public async Task<IEnumerable<Project>> GetMainProjectsAsync() => await _dbContext.Projects.Take(5).ToListAsync();

        public async Task<IEnumerable<Project>> GetProjectsAsync() => await _dbContext.Projects.OrderByDescending(x => x.Id).ToListAsync();

        public void ProjectCreate(string title, string alias, string titleH1, string square, string city,
            decimal? price)
        {
            Project project = new Project
            {
                Title = title,
                Alias = alias,
                TitleH1 = titleH1,
                Square = square,
                City = city,
                Price = price
            };

            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public Project GetProject(int id) => _dbContext.Projects.SingleOrDefault(x => x.Id == id);

        public async Task<Project> GetProjectAsync(string alias) =>
            await _dbContext.Projects.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ProjectEdit(int id, string title, string titleH1, string alias, string square, string city,
            decimal? price)
        {
            Project project = GetProject(id);

            if (project != null)
            {
                project.Title = title;
                project.TitleH1 = titleH1;
                project.Alias = alias;
                project.Square = square;
                project.City = city;
                project.Price = price;
            }

            _dbContext.SaveChanges();
        }

        public void ProjectImageEdit(int id, string img, string banner)
        {
            Project project = GetProject(id);

            if (project != null)
            {
                project.Img = img;
                project.Banner = banner;
            }

            _dbContext.SaveChanges();
        }

        public void ProjectAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description)
        {
            Project project = GetProject(id);

            if (project != null)
            {
                project.TitleAlbum = titleAlbum;
                project.AlbumId = albumId;
                project.LinkAlbum = linkAlbum;
                project.Description1 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ProjectVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description)
        {
            Project project = GetProject(id);

            if (project != null)
            {
                project.TitleVideo = titleVideo;
                project.LinkVideo = linkVideo;
                project.PreviewVideo = previewVideo;
                project.Description2 = description;
            }

            _dbContext.SaveChanges();
        }

        public void ProjectSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Project project = GetProject(id);

            if (project != null)
            {
                project.SeoTitle = seoTitle;
                project.SeoKeywords = seoKeywords;
                project.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ProjectDelete(Project project)
        {
            _dbContext.Projects.Remove(project);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Floor

        public IEnumerable<Floor> GetFloors() => _dbContext.Floors;

        public async Task<IEnumerable<Floor>> GetFloorsAsync() => await _dbContext.Floors.ToListAsync();

        public async Task<Floor> GetFloorAsync(string alias) =>
            await _dbContext.Floors.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void FloorCreate(string title, string titleH1, string alias, string description, string icon)
        {
            Floor floor = new Floor
            {
                Title = title,
                TitleH1 = titleH1,
                Alias = alias,
                Description1 = description,
                Icon = icon
            };

            _dbContext.Floors.Add(floor);
            _dbContext.SaveChanges();
        }

        public Floor GetFloor(int id) => _dbContext.Floors.SingleOrDefault(x => x.Id == id);

        public void FloorEdit(int id, string title, string titleH1, string alias, string description, string icon)
        {
            Floor floor = GetFloor(id);

            if (floor != null)
            {
                floor.Title = title;
                floor.TitleH1 = titleH1;
                floor.Alias = alias;
                floor.Description1 = description;
                floor.Icon = icon;
            }

            _dbContext.SaveChanges();
        }

        public void FloorAlbum(int id, string titleAlbum, int albumId, string linkAlbum, string description)
        {
            Floor floor = GetFloor(id);

            if (floor != null)
            {
                floor.TitleAlbum = titleAlbum;
                floor.AlbumId = albumId;
                floor.LinkAlbum = linkAlbum;
                floor.Description2 = description;
            }

            _dbContext.SaveChanges();
        }

        public void FloorSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Floor floor = GetFloor(id);

            if (floor != null)
            {
                floor.SeoTitle = seoTitle;
                floor.SeoKeywords = seoKeywords;
                floor.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void FloorProduct(int id, string titleProducts, string description)
        {
            Floor floor = GetFloor(id);

            if (floor != null)
            {
                floor.TitleProducts = titleProducts;
                floor.Description3 = description;
            }

            _dbContext.SaveChanges();
        }

        public void AddProductForFloor(int floorId, int prodId)
        {
            FloorProduct floorProduct = new FloorProduct
            {
                FloorId = floorId,
                ProductId = prodId
            };

            _dbContext.FloorProducts.Add(floorProduct);
            _dbContext.SaveChanges();
        }

        public IEnumerable<FloorProduct> GetFloorProducts(int id) =>
            _dbContext.FloorProducts.Where(x => x.FloorId == id);

        public FloorProduct GetFloorProduct(int productId, int floorId) =>
            _dbContext.FloorProducts.FirstOrDefault(x => x.ProductId == productId && x.FloorId == floorId);

        public void FloorProductDelete(FloorProduct model)
        {
            _dbContext.FloorProducts.Remove(model);
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetFloorProductsAsync(int floorId) =>
            await (from x in _dbContext.Products
                   join c in _dbContext.FloorProducts.Where(x => x.FloorId == floorId) on x.Id equals c.ProductId
                   select new Product
                   {
                       Id = x.Id,
                       Title = x.Title,
                       SubTitle = x.SubTitle,
                       Alias = x.Alias,
                       Img1 = x.Img1,
                       PriceKg = x.PriceKg,
                       PriceKit = x.PriceKit,
                       Stock = x.Stock
                   }).ToListAsync();

        public void FloorQuestion(int id, string titleQuestion, string description)
        {
            Floor floor = GetFloor(id);

            if (floor != null)
            {
                floor.TitleQuestion = titleQuestion;
                floor.Description4 = description;
            }

            _dbContext.SaveChanges();
        }

        public void AddQuestionForFloor(int floorId, int artId)
        {
            FloorQuestion floorQuestion = new FloorQuestion
            {
                FloorId = floorId,
                ArtId = artId
            };

            _dbContext.FloorQuestions.Add(floorQuestion);
            _dbContext.SaveChanges();
        }

        public void FloorQuestionDelete(FloorQuestion model)
        {
            _dbContext.FloorQuestions.Remove(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<FloorQuestion> GetFloorQuestions(int id) =>
            _dbContext.FloorQuestions.Where(x => x.FloorId == id);

        public async Task<IEnumerable<Article>> GetFloorQuestionsAsync(int floorId) =>
            await (from x in _dbContext.Articles
                   join c in _dbContext.FloorQuestions.Where(x => x.FloorId == floorId) on x.Id equals c.ArtId
                   select new Article
                   {
                       Id = x.Id,
                       Title = x.Title,
                       SubTitle = x.SubTitle,
                       Alias = x.Alias,
                       CreationDate = x.CreationDate
                   }).ToListAsync();

        public FloorQuestion GetFloorQuestion(int artId, int floorId) =>
            _dbContext.FloorQuestions.FirstOrDefault(x => x.ArtId == artId && x.FloorId == floorId);

        public void FloorDeleteAllMaterials(int id)
        {
            _dbContext.FloorProducts.RemoveRange(GetFloorProducts(id));
            _dbContext.SaveChanges();
        }

        public void FloorDeleteAllQuestions(int id)
        {
            _dbContext.FloorQuestions.RemoveRange(GetFloorQuestions(id));
            _dbContext.SaveChanges();
        }

        public void FloorDelete(Floor floor)
        {
            _dbContext.Floors.Remove(floor);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Article

        public IEnumerable<Article> GetArticles() => _dbContext.Articles;

        public async Task<IEnumerable<Article>> GetMainQuestionsAsync() =>
            await _dbContext.Articles.Where(x => x.IsMainPage && x.IsNews == false).Take(3).ToListAsync();

        public async Task<IEnumerable<Article>> GetMainNewsAsync() =>
            await _dbContext.Articles.Where(x => x.IsMainPage && x.IsNews).Take(3).ToListAsync();

        public async Task<IEnumerable<Article>> GetNewsAsync() =>
            await _dbContext.Articles.Where(x => x.IsNews).OrderByDescending(x => x.CreationDate).ToListAsync();

        public async Task<IEnumerable<Article>> GetArticlesAsync() => await _dbContext.Articles
            .Where(x => x.IsNews == false).OrderByDescending(x => x.CreationDate).ToListAsync();

        public async Task<IEnumerable<Article>> GetNewsAsync(int? catId) =>
            await _dbContext.Articles.Where(x => x.IsNews && x.CategoryId == catId).OrderByDescending(x => x.CreationDate).ToListAsync();

        public async Task<IEnumerable<Article>> GetArticleAsync(int? catId) =>
            await _dbContext.Articles.Where(x => x.IsNews == false && x.CategoryId == catId).OrderByDescending(x => x.CreationDate).ToListAsync();

        public async Task<IEnumerable<Article>> GetNewsTakeAsync() =>
            await _dbContext.Articles.Where(x => x.IsNews).OrderByDescending(x => x.CreationDate).Take(3).ToListAsync();

        public async Task<IEnumerable<Article>> GetArticlesTakeAsync() =>
            await _dbContext.Articles.Where(x => x.IsNews == false).OrderByDescending(x => x.CreationDate).Take(3).ToListAsync();

        public IEnumerable<ArticleCategory> ArticleCategories() => _dbContext.ArticleCategories;

        public async Task<IEnumerable<ArticleCategory>> ArticleCategoriesAsync() =>
            await _dbContext.ArticleCategories.Where(x => x.IsNews == false).ToListAsync();

        public async Task<IEnumerable<ArticleCategory>> NewsCategoriesAsync() =>
            await _dbContext.ArticleCategories.Where(x => x.IsNews).ToListAsync();

        public ArticleCategory GetArticleCategory(int id) =>
            _dbContext.ArticleCategories.SingleOrDefault(x => x.Id == id);

        public async Task<ArticleCategory> GetNewsCategoryAsync(string alias) => await _dbContext.ArticleCategories
            .Where(x => x.IsNews).SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public async Task<ArticleCategory> GetArticleCategoryAsync(string alias) => await _dbContext.ArticleCategories
            .Where(x => x.IsNews == false).SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ArticleCategoryCreate(ArticleCategory model)
        {
            _dbContext.ArticleCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public void ArticleCategoryEdit(ArticleCategory model)
        {
            ArticleCategory articleCategory = GetArticleCategory(model.Id);

            if (articleCategory != null)
            {
                articleCategory.Title = model.Title;
                articleCategory.Alias = model.Alias;
                articleCategory.IsNews = model.IsNews;
                articleCategory.SeoTitle = model.SeoTitle;
                articleCategory.SeoKeywords = model.SeoKeywords;
                articleCategory.SeoDescription = model.SeoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ArticleCategoryDelete(ArticleCategory model)
        {
            _dbContext.ArticleCategories.Remove(model);
            _dbContext.SaveChanges();
        }

        public Article GetArticle(int id) => _dbContext.Articles.SingleOrDefault(x => x.Id == id);

        public async Task<Article> GetNewsOpenAsync(string alias) => await _dbContext.Articles.Where(x => x.IsNews)
            .SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public async Task<Article> GetArticleOpenAsync(string alias) => await _dbContext.Articles
            .Where(x => x.IsNews == false).SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void ArticleCreate(Article model)
        {
            _dbContext.Articles.Add(model);
            _dbContext.SaveChanges();
        }

        public void ArticleEdit(Article model)
        {
            Article article = GetArticle(model.Id);

            if (article != null)
            {
                article.Title = model.Title;
                article.TitleH1 = model.TitleH1;
                article.Alias = model.Alias;
                article.SubTitle = model.SubTitle;
                article.IsMainPage = model.IsMainPage;
                article.CreationDate = model.CreationDate;
                article.Description = model.Description;
                article.CategoryId = model.CategoryId;
                article.IsNews = model.IsNews;
            }

            _dbContext.SaveChanges();
        }

        public void ArticleDelete(Article model)
        {
            _dbContext.Articles.Remove(model);
            _dbContext.SaveChanges();
        }

        public void ArticleImage(int id, string img, string imgOpenPage)
        {
            Article article = GetArticle(id);

            if (article != null)
            {
                article.Img = img;
                article.ImgOpenPage = imgOpenPage;
            }

            _dbContext.SaveChanges();
        }

        public void ArticleSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Article article = GetArticle(id);

            if (article != null)
            {
                article.SeoTitle = seoTitle;
                article.SeoKeywords = seoKeywords;
                article.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        #endregion

        #region Tv

        public IEnumerable<Tv> GetTvs() => _dbContext.Tvs;

        public async Task<IEnumerable<Tv>> GetTvsAsync() =>
            await _dbContext.Tvs.OrderByDescending(x => x.Id).Where(x => x.IsTv == false).ToListAsync();

        public async Task<IEnumerable<Tv>> GetObuchenieListAsync() =>
            await _dbContext.Tvs.OrderByDescending(x => x.Id).Where(x => x.IsTv == true).ToListAsync();

        public void TvCreate(string icon, string banner, string caption, string title, string subTitle, string titleH1,
            string alias, string description, bool isTv)
        {
            Tv tv = new Tv
            {
                Icon = icon,
                Banner = banner,
                Caption = caption,
                Title = title,
                SubTitle = subTitle,
                TitleH1 = titleH1,
                Alias = alias,
                Description1 = description,
                IsTv = isTv
            };

            _dbContext.Tvs.Add(tv);
            _dbContext.SaveChanges();
        }

        public Tv GetTv(int id) => _dbContext.Tvs.SingleOrDefault(x => x.Id == id);

        public async Task<Tv> GetTvAsync(string alias) =>
            await _dbContext.Tvs.OrderByDescending(x => x.Id)
                .SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void TvEdit(int id, string icon, string banner, string caption, string title, string subTitle,
            string titleH1, string alias, string description, bool isTv)
        {
            Tv tv = GetTv(id);

            if (tv != null)
            {
                tv.Icon = icon;
                tv.Banner = banner;
                tv.Caption = caption;
                tv.Title = title;
                tv.SubTitle = subTitle;
                tv.TitleH1 = titleH1;
                tv.Alias = alias;
                tv.Description1 = description;
                tv.IsTv = isTv;
            }

            _dbContext.SaveChanges();
        }

        public void TvAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description)
        {
            Tv tv = GetTv(id);

            if (tv != null)
            {
                tv.TitleAlbum = titleAlbum;
                tv.AlbumId = albumId;
                tv.LinkAlbum = linkAlbum;
                tv.Description2 = description;
            }

            _dbContext.SaveChanges();
        }

        public void TvVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description)
        {
            Tv tv = GetTv(id);

            if (tv != null)
            {
                tv.TitleVideo = titleVideo;
                tv.LinkVideo = linkVideo;
                tv.PreviewVideo = previewVideo;
                tv.Description3 = description;
            }

            _dbContext.SaveChanges();
        }

        public void TvSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Tv tv = GetTv(id);

            if (tv != null)
            {
                tv.SeoTitle = seoTitle;
                tv.SeoKeywords = seoKeywords;
                tv.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void TvDelete(Tv tv)
        {
            _dbContext.Tvs.Remove(tv);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Video

        public IEnumerable<Video> GetVideos() => _dbContext.Videos.OrderByDescending(x => x.Id);

        public async Task<IEnumerable<Video>> GetVideosAsync() => await _dbContext.Videos.OrderByDescending(x => x.Id).ToListAsync();

        public async Task<IEnumerable<Video>> GetMainVideosAsync() => await _dbContext.Videos.OrderByDescending(x => x.Id).Take(4).ToListAsync();

        public async Task<IEnumerable<Video>> GetVideoAsync(int? catId) => await _dbContext.Videos.Where(x => x.CategoryId == catId).ToListAsync();

        public void VideoCreate(string title, string titleH1, string alias, string description, string thumb, string banner, string linkVideo, int? catId)
        {
            Video video = new Video
            {

                Title = title,
                TitleH1 = titleH1,
                Alias = alias,
                Description = description,
                Thumb = thumb,
                Banner = banner,
                LinkVideo = linkVideo,
                CategoryId = catId
            };

            _dbContext.Videos.Add(video);
            _dbContext.SaveChanges();
        }

        public Video GetVideo(int id) => _dbContext.Videos.SingleOrDefault(x => x.Id == id);

        public async Task<IEnumerable<Video>> GetVideosTakeAsync() => await _dbContext.Videos.Take(3).ToListAsync();

        public async Task<Video> GetVideoOpenAsync(string alias) => await _dbContext.Videos.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void VideoEdit(int id, string title, string titleH1, string alias, string description, string thumb, string banner, string linkVideo, int? catId)
        {
            Video video = GetVideo(id);

            if (video != null)
            {
                video.Title = title;
                video.TitleH1 = titleH1;
                video.Alias = alias;
                video.Description = description;
                video.Thumb = thumb;
                video.Banner = banner;
                video.LinkVideo = linkVideo;
                video.CategoryId = catId;
            }

            _dbContext.SaveChanges();
        }

        public void VideoSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Video video = GetVideo(id);

            if (video != null)
            {
                video.SeoTitle = seoTitle;
                video.SeoKeywords = seoKeywords;
                video.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void VideoDelete(Video video)
        {
            _dbContext.Videos.Remove(video);
            _dbContext.SaveChanges();
        }

        public IEnumerable<VideoCategory> VideoCategories() => _dbContext.VideoCategories;

        public async Task<IEnumerable<VideoCategory>> VideoCategoriesAsync() =>
            await _dbContext.VideoCategories.ToListAsync();

        public VideoCategory GetVideoCategory(int id) =>
            _dbContext.VideoCategories.SingleOrDefault(x => x.Id == id);

        public async Task<VideoCategory> GetVideoCategoryAsync(string alias) => await _dbContext.VideoCategories.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void VideoCategoryCreate(VideoCategory model)
        {
            _dbContext.VideoCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public void VideoCategoryEdit(VideoCategory model)
        {
            VideoCategory videoCategory = GetVideoCategory(model.Id);

            if (videoCategory != null)
            {
                videoCategory.Title = model.Title;
                videoCategory.Alias = model.Alias;
                videoCategory.SeoTitle = model.SeoTitle;
                videoCategory.SeoKeywords = model.SeoKeywords;
                videoCategory.SeoDescription = model.SeoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void VideoCategoryDelete(VideoCategory model)
        {
            _dbContext.VideoCategories.Remove(model);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Region

        public IEnumerable<Region> GetRegions() => _dbContext.Regions;

        public async Task<IEnumerable<RegionCategory>> GetRegionsCategoryAsync() => await _dbContext.RegionCategories.ToListAsync();

        public async Task<IEnumerable<Region>> GetRegionsAsync() => await _dbContext.Regions.ToListAsync();

        public IEnumerable<RegionCategory> RegionCategories() => _dbContext.RegionCategories;

        public RegionCategory GetRegionCategory(int id) =>
            _dbContext.RegionCategories.SingleOrDefault(x => x.Id == id);

        public void RegionCategoryCreate(RegionCategory model)
        {
            _dbContext.RegionCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public void RegionCategoryEdit(RegionCategory model)
        {
            RegionCategory regionCategory = GetRegionCategory(model.Id);

            if (regionCategory != null)
            {
                regionCategory.Title = model.Title;
                regionCategory.Alias = model.Alias;
            }

            _dbContext.SaveChanges();
        }

        public void RegionCategoryDelete(RegionCategory model)
        {
            _dbContext.RegionCategories.Remove(model);
            _dbContext.SaveChanges();
        }

        public Region GetRegion(int id) => _dbContext.Regions.SingleOrDefault(x => x.Id == id);

        public async Task<Region> GetRegionAsync(string alias) =>
            await _dbContext.Regions.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void RegionCreate(Region model)
        {
            _dbContext.Regions.Add(model);
            _dbContext.SaveChanges();
        }

        public void RegionEdit(Region model)
        {
            Region region = GetRegion(model.Id);

            if (region != null)
            {
                region.Title = model.Title;
                region.TitleH1 = model.TitleH1;
                region.Alias = model.Alias;
                region.Description = model.Description;
                region.CategoryId = model.CategoryId;
                region.Index = model.Index;
                region.Phone = model.Phone;
                region.Email = model.Email;
                region.Address = model.Address;
            }

            _dbContext.SaveChanges();
        }

        public void RegionDelete(Region model)
        {
            _dbContext.Regions.Remove(model);
            _dbContext.SaveChanges();
        }

        public void RegionSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Region region = GetRegion(id);

            if (region != null)
            {
                region.SeoTitle = seoTitle;
                region.SeoKeywords = seoKeywords;
                region.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void RegionAlbum(int id, string titleAlbum, int? albumId, string linkAlbum, string description)
        {
            Region region = GetRegion(id);

            if (region != null)
            {
                region.TitleAlbum = titleAlbum;
                region.AlbumId = albumId;
                region.LinkAlbum = linkAlbum;
                region.Description2 = description;
            }

            _dbContext.SaveChanges();
        }

        public void RegionVideo(int id, string titleVideo, string linkVideo, string previewVideo, string description)
        {
            Region region = GetRegion(id);

            if (region != null)
            {
                region.TitleVideo = titleVideo;
                region.LinkVideo = linkVideo;
                region.PreviewVideo = previewVideo;
                region.Description3 = description;
            }

            _dbContext.SaveChanges();
        }

        public void AddProductForRegion(int regionId, int prodId)
        {
            RegionProduct regionProduct = new RegionProduct
            {
                RegionId = regionId,
                ProductId = prodId
            };

            _dbContext.RegionProducts.Add(regionProduct);
            _dbContext.SaveChanges();
        }

        public void RegionProduct(int id, string titleProducts, string description)
        {
            Region region = GetRegion(id);

            if (region != null)
            {
                region.TitleProducts = titleProducts;
                region.Description4 = description;
            }

            _dbContext.SaveChanges();
        }

        public IEnumerable<RegionProduct> GetRegionProducts(int id) =>
            _dbContext.RegionProducts.Where(x => x.RegionId == id);

        public RegionProduct GetRegionProduct(int productId, int regionId) =>
            _dbContext.RegionProducts.FirstOrDefault(x => x.ProductId == productId && x.RegionId == regionId);

        public void RegionProductDelete(RegionProduct model)
        {
            _dbContext.RegionProducts.Remove(model);
            _dbContext.SaveChanges();
        }

        public void RegionDeleteAllMaterials(int id)
        {
            _dbContext.RegionProducts.RemoveRange(GetRegionProducts(id));
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetRegionProductsAsync(int id)
        {
            return await (from x in _dbContext.Products
                          join c in _dbContext.RegionProducts.Where(x => x.RegionId == id) on x.Id equals c.ProductId
                          select new Product
                          {
                              Id = x.Id,
                              Title = x.Title,
                              SubTitle = x.SubTitle,
                              Alias = x.Alias,
                              Img1 = x.Img1,
                              PriceKg = x.PriceKg,
                              PriceKit = x.PriceKit,
                              Stock = x.Stock
                          }).ToListAsync();
        }

        #endregion

        #region Contacts

        public IEnumerable<Contact> GetContacts() => _dbContext.Contacts;

        public async Task<IEnumerable<Contact>> GetContactsAsync() => await _dbContext.Contacts.ToListAsync();

        public Contact GetContact(int id) => _dbContext.Contacts.SingleOrDefault(x => x.Id == id);

        public async Task<Contact> GetMainContactAsync() => await _dbContext.Contacts.FirstOrDefaultAsync(x => x.IsMain == true);

        public void ContactCreate(Contact model)
        {
            _dbContext.Contacts.Add(model);
            _dbContext.SaveChanges();
        }

        public void ContactEdit(Contact model)
        {
            Contact contact = GetContact(model.Id);

            if (contact != null)
            {
                contact.Title = model.Title;
                contact.Address = model.Address;
                contact.Anchor = model.Anchor;
                contact.CodeMap = model.CodeMap;
                contact.Email = model.Email;
                contact.IsMain = model.IsMain;
                contact.Phone = model.Phone;
                contact.Schedule = model.Schedule;
                contact.UrltoPageRegion = model.UrltoPageRegion;
            }

            _dbContext.SaveChanges();
        }

        public void ContactDelete(Contact model)
        {
            _dbContext.Contacts.Remove(model);
            _dbContext.SaveChanges();
        }

        #endregion

        #region Page

        public IEnumerable<Page> GetPages() => _dbContext.Pages;

        public Page GetPage(int id) => _dbContext.Pages.SingleOrDefault(x => x.Id == id);

        public async Task<Page> GetPageAsync(string alias) =>
            await _dbContext.Pages.SingleOrDefaultAsync(x => x.Alias.ToLower() == alias.ToLower());

        public void PageCreate(Page model)
        {
            _dbContext.Pages.Add(model);
            _dbContext.SaveChanges();
        }

        public void PageEdit(Page model)
        {
            Page page = GetPage(model.Id);

            if (page != null)
            {
                page.Title = model.Title;
                page.TitleH1 = model.TitleH1;
                page.Alias = model.Alias;
                page.Description = model.Description;
            }

            _dbContext.SaveChanges();
        }

        public void PageDelete(Page model)
        {
            _dbContext.Pages.Remove(model);
            _dbContext.SaveChanges();
        }

        public void PageSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            Page page = GetPage(id);

            if (page != null)
            {
                page.SeoTitle = seoTitle;
                page.SeoKeywords = seoKeywords;
                page.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        #endregion

        #region Counter

        public IEnumerable<Counter> Counters() => _dbContext.Counters;

        public async Task<IEnumerable<Counter>> CountersAsync() => await _dbContext.Counters.ToListAsync();

        public Counter GetCounter(int id) => _dbContext.Counters.SingleOrDefault(x => x.Id == id);

        public void CounterCreate(Counter counter)
        {
            _dbContext.Counters.Add(counter);
            _dbContext.SaveChanges();
        }

        public void CounterDelete(Counter counter)
        {
            _dbContext.Counters.Remove(counter);
            _dbContext.SaveChanges();
        }

        public void CounterEdit(Counter model)
        {
            Counter counter = GetCounter(model.Id);

            if (counter != null)
            {
                counter.MetaTag = model.MetaTag;
                counter.CodeTop = model.CodeTop;
                counter.CodeBottom = model.CodeBottom;
            }

            _dbContext.SaveChanges();
        }

        #endregion

        #region Calc

        public void CalcCategoryCreate(CalcCategory model)
        {
            _dbContext.CalcCategories.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<CalcCategory> CalcCategories() => _dbContext.CalcCategories.ToList();

        public CalcCategory GetCalcCategory(int id) => _dbContext.CalcCategories.SingleOrDefault(x => x.Id == id);

        public CalcCategory GetCalcCategoryAlias(string alias) => _dbContext.CalcCategories.SingleOrDefault(x => x.Alias == alias);

        public void CalcCategoryEdit(CalcCategory model)
        {
            CalcCategory calcCategory = GetCalcCategory(model.Id);

            if (calcCategory != null)
            {
                calcCategory.Title = model.Title;
                calcCategory.TitleH1 = model.TitleH1;
                calcCategory.Desc = model.Desc;
                calcCategory.Glossy = model.Glossy;
                calcCategory.SemiMatt = model.SemiMatt;
                calcCategory.Matt = model.Matt;
                calcCategory.Smooth = model.Smooth;
                calcCategory.Grungy = model.Grungy;
                calcCategory.Alias = model.Alias;
            }

            _dbContext.SaveChanges();
        }

        public void CalcThickCreate(int id, int mm, string comment)
        {
            CalcThick calcThick = new CalcThick
            {
                Mm = mm,
                Comment = comment,
                CalcCategoryId = id
            };

            _dbContext.CalcThicks.Add(calcThick);
            _dbContext.SaveChanges();
        }

        public IEnumerable<CalcThick> CalcThicks(int id) => _dbContext.CalcThicks.Where(x => x.CalcCategoryId == id).OrderBy(x => x.Mm).ToList();

        public void CalcThickDelete(CalcThick model)
        {
            _dbContext.CalcThicks.Remove(model);
            _dbContext.SaveChanges();
        }

        public CalcThick GetCalcThick(int id) => _dbContext.CalcThicks.SingleOrDefault(x => x.Id == id);

        public void CalcProductCreate(int productId, int id, bool glossy, bool semiMatt, bool matt, bool smooth, bool grungy, string kg)
        {
            Product product = GetProduct(productId);

            CalcProduct model = new CalcProduct
            {
                ProductId = productId,
                CalcCategoryId = id,
                Glossy = glossy,
                SemiMatt = semiMatt,
                Matt = matt,
                Smooth = smooth,
                Grungy = grungy,
                Kg = kg,
                PrTitle = product.Title,
                PrPriceKg = product.PriceKg,
                PrPriceKit = product.PriceKit
            };
            _dbContext.CalcProducts.Add(model);
            _dbContext.SaveChanges();
        }

        public IEnumerable<CalcProduct> CalcProducts(int id) => _dbContext.CalcProducts.Where(x => x.CalcCategoryId == id).ToList();

        public IEnumerable<CalcProduct> CalcProductsFilter(int id, string varnish, string surface)
        {
            IEnumerable<CalcProduct> model = _dbContext.CalcProducts.Where(x => x.CalcCategoryId == id && x.Matt == false);

            //if (varnish == "Глянцевый")
            //{
            //    model = model.Where(x => x.Glossy);
            //}
            //if (varnish == "Полуматовый")
            //{
            //    model = model.Where(x => x.SemiMatt);
            //}
            if (varnish == "Матовый")
            {
                model = _dbContext.CalcProducts.Where(x => x.CalcCategoryId == id);
            }
            //if (surface == "Гладкая")
            //{
            //    model = model.Where(x => x.Smooth);
            //}
            //if (surface == "Шероховатая")
            //{
            //    model = model.Where(x => x.Grungy);
            //}
            return model;
        }

        public CalcProduct GetCalcProduct(int id) => _dbContext.CalcProducts.SingleOrDefault(x => x.Id == id);

        public void CalcProductDelete(CalcProduct model)
        {
            _dbContext.CalcProducts.Remove(model);
            _dbContext.SaveChanges();
        }

        public void CalcProductEdit(int productId, int id, bool glossy, bool semiMatt, bool matt, bool smooth, bool grungy, string kg, int thisId)
        {
            CalcProduct calcProduct = GetCalcProduct(thisId);
            Product product = GetProduct(productId);

            if (calcProduct != null)
            {
                calcProduct.ProductId = productId;
                calcProduct.CalcCategoryId = id;
                calcProduct.Glossy = glossy;
                calcProduct.SemiMatt = semiMatt;
                calcProduct.Matt = matt;
                calcProduct.Smooth = smooth;
                calcProduct.Grungy = grungy;
                calcProduct.Kg = kg;
                calcProduct.PrTitle = product.Title;
                calcProduct.PrPriceKg = product.PriceKg;
                calcProduct.PrPriceKit = product.PriceKit;
            }

            _dbContext.SaveChanges();
        }

        public void CalcCategoryDelete(CalcCategory model)
        {
            _dbContext.CalcCategories.Remove(model);
            _dbContext.CalcThicks.RemoveRange(CalcThicks(model.Id));
            _dbContext.CalcProducts.RemoveRange(CalcProducts(model.Id));
            _dbContext.SaveChanges();
        }

        public void CalcSeo(int id, string seoTitle, string seoKeywords, string seoDescription)
        {
            CalcCategory calcCategory = GetCalcCategory(id);

            if (calcCategory != null)
            {
                calcCategory.SeoTitle = seoTitle;
                calcCategory.SeoKeywords = seoKeywords;
                calcCategory.SeoDescription = seoDescription;
            }

            _dbContext.SaveChanges();
        }

        public void ReviewCreat(Review model)
        {
            _dbContext.Reviews.Add(model);
            _dbContext.SaveChanges();
        }

        public async Task<List<Review>> GetAllReview()
        {
            return await _dbContext.Reviews.ToListAsync();
        } 
        public async Task<List<Review>> GetOnlyFalseReview()
        {
            return await _dbContext.Reviews.Where(x => x.IsAllowed == true).ToListAsync();
        } 

        public Review ReviewGet(int id)=>_dbContext.Reviews.SingleOrDefault(x => x.Id == id);

        #endregion
    }
}
