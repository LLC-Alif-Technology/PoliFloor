using AutoMapper;
using KagamaAdmin.Models;
using KagamaAdmin.ViewModel;
using KagamaModels;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace KagamaAdmin.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _appEnvironment;
        private IKagamaRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        readonly IMapper _mapper;

        public HomeController(IKagamaRepository repository, IHttpContextAccessor httpContextAccessor, IMapper mapper, IHostingEnvironment appEnvironment)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
        }

        protected T GetSession<T>(ISession session, string name)
        {
            var value = session.GetString(name);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }

        protected void SetSession(ISession session, string name, object value)
        {
            session.SetString(name, JsonConvert.SerializeObject(value));
        }

        protected CartView GetCart()
        {
            var cart = GetSession<CartView>(_session, "cart");

            if (cart == null)
            {
                cart = new CartView();
                SetSession(_session, "cart", cart);
            }

            return cart;
        }

        [Route("/")]
        [Route("/{alias}")]
        public async Task<IActionResult> Index(string alias)
        {
            Page page = await _repository.GetPageAsync("Glavnaya");

            if (!string.IsNullOrEmpty(alias))
            {
                Service service = await _repository.GetServiceAsync(alias);

                if (service == null)
                    return NotFound();

                page = await _repository.GetPageAsync("Uslugi");

                if (page == null)
                    return NotFound();

                ServicesView model = new ServicesView
                {
                    Page = page,
                    Services = await _repository.GetServicesAsync(),
                    Service = service,
                    GalleryItems = await _repository.GetGalleryItemTakeAsync(service.AlbumId),
                    Products = await _repository.GetServiceProductsAsync(service.Id),
                    CartView = GetCart(),
                    Projects = await _repository.GetServiceProjectsAsync(service.Id),
                    Floors = await _repository.GetServiceFloorsAsync(service.Id),
                    Articles = await _repository.GetServiceQuestionsAsync(service.Id),
                    EUR = _repository.GetEurCourse("eur").Course
                };

                if (service.CalcId != null)
                {
                    model.CalcCategory = _repository.GetCalcCategory((int)service.CalcId);
                    model.CalcThicks = _repository.CalcThicks((int)service.CalcId);
                    ViewBag.CalcThicks = new SelectList(model.CalcThicks, "Mm", "Mm");
                }

                return View("Service", model);
            }

            if (page == null)
                return NotFound();

            return View(page);
        }

        [Route("/{alias}")]
        [HttpPost]
        public async Task<IActionResult> Index(string alias, ServicesView model)
        {
            if (!string.IsNullOrEmpty(alias))
            {
                Service service = await _repository.GetServiceAsync(alias);

                if (service == null)
                    return NotFound();

                Page page = await _repository.GetPageAsync("Uslugi");

                if (page == null)
                    return NotFound();

                model.Page = page;
                model.Services = await _repository.GetServicesAsync();
                model.Service = service;
                model.GalleryItems = await _repository.GetGalleryItemTakeAsync(service.AlbumId);
                model.Products = await _repository.GetServiceProductsAsync(service.Id);
                model.CartView = GetCart();
                model.Projects = await _repository.GetServiceProjectsAsync(service.Id);
                model.Floors = await _repository.GetServiceFloorsAsync(service.Id);
                model.Articles = await _repository.GetServiceQuestionsAsync(service.Id);
                model.EUR = _repository.GetEurCourse("eur").Course;

                if (service.CalcId != null)
                {
                    model.CalcCategory = _repository.GetCalcCategory((int)service.CalcId);
                    model.CalcThicks = _repository.CalcThicks((int)service.CalcId);
                    ViewBag.CalcThicks = new SelectList(model.CalcThicks, "Mm", "Mm");
                }

                model.CalcProducts = _repository.CalcProductsFilter(model.CalcCategory.Id, model.Varnish, model.Surface);

                foreach (var p in model.CalcProducts)
                {
                    var arr = p.Kg.Split(';');
                    string str = "";
                    for (var i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].StartsWith(model.Thick.ToString()))
                        {
                            str = arr[i];
                            break;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(str))
                    {
                        p.Kg = str.Substring(str.IndexOf('-') + 1);
                    }
                    model.AllKg += float.Parse(p.Kg);

                    model.TotalSum += Convert.ToDecimal(p.PrPriceKg * model.EUR) * ((Convert.ToDecimal(p.Kg) / 1000) * model.Area);
                }

                ViewBag.Section = "CalcForm";
                return View("Service", model);
            }
            return RedirectToAction("Index");
        }

        [Route("MainLead")]
        [HttpPost]
        public async Task<IActionResult> MainLead(MainLeadView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.Name + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.Email + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.Phone + "<br>";
                    foreach (var cover in model.Covering)
                    {
                        bodyContent += "<b style='width:140px; display:inline-block;'>Покрытие</b> - " + cover + "<br>";
                    }
                    bodyContent += "<b style='width:140px; display:inline-block;'>Площадь</b> - " + model.Square + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Город</b> - " + model.City + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Адрес</b> - " + model.Address + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Комментарий</b> - " + model.Description + "<br>";

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма оставить заявку", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("MainLead", model);
        }

        [Route("ModalLead")]
        [HttpPost]
        public async Task<IActionResult> ModalLead(ModalLeadView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.MName + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.MEmail + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.MPhone + "<br>";
                    foreach (var cover in model.MCovering)
                    {
                        bodyContent += "<b style='width:140px; display:inline-block;'>Покрытие</b> - " + cover + "<br>";
                    }
                    bodyContent += "<b style='width:140px; display:inline-block;'>Площадь</b> - " + model.MSquare + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Город</b> - " + model.MCity + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Адрес</b> - " + model.MAddress + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Комментарий</b> - " + model.MDescription + "<br>";

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма оставить заявку", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("ModalLead", model);
        }

        [Route("ModalCall")]
        [HttpPost]
        public async Task<IActionResult> ModalCall(ModalCallView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.ModalCallName + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Номер телефона </b> - " + model.ModalCallPhone + "<br>";

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма заказать звонок", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("ModalCall", model);
        }

        [Route("QuestionsTab")]
        [HttpPost]
        public async Task<IActionResult> QuestionsTab(QuestionsTabView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.Name + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.Email + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.Phone + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Город</b> - " + model.City + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Комментарий</b> - " + model.Description + "<br>";

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма задать вопрос", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("QuestionsTab", model);
        }

        [Route("ServiceForm")]
        [HttpPost]
        public async Task<IActionResult> ServiceForm(ServiceFormView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.SoName + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.SoEmail + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.SoPhone + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Количество м2</b> - " + model.SoCount + "<br>";

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма срочный расчет", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("ServiceForm", model);
        }

        [Route("RegionForm")]
        [HttpPost]
        public async Task<IActionResult> RegionForm(RegionFormView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.ReName + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.ReEmail + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.RePhone + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Количество м2</b> - " + model.ReCount + "<br>";
                    foreach (var cover in model.ReCovering)
                    {
                        bodyContent += "<b style='width:140px; display:inline-block;'>Покрытие</b> - " + cover + "<br>";
                    }

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма рассчитать стоимость", bodyContent);

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("RegionForm", model);
        }

        [Route("CalcOrder")]
        [HttpPost]
        public async Task<IActionResult> CartOrder(CalcOrderView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var bodyContent = "";
                    bodyContent = "<b style='width:180px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Форма</b> - " + model.FormTitle + "<br>";

                    bodyContent += "<b style='width:180px; display:inline-block;'>Площадь</b> - " + model.FormArea + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Толщина</b> - " + model.FormThick + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Лак</b> - " + (model.FormVarnish ? "Выбран матовый лак" : "Не выбарн") + "<br>";

                    bodyContent += "<b style='width:180px; display:inline-block;'>Имя </b> - " + model.Name + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Почта</b> - " + model.Email + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Телефон</b> - " + model.Phone + "<br>";
                    bodyContent += "<b style='width:180px; display:inline-block;'>Комментарий</b> - " + model.Description + "<br>";

                    if (model.FormTitle.ToLower() == "Оформить заказ".ToLower())
                    {
                        bodyContent += "<b style='width:180px; display:inline-block;'>Результаты рассчета</b><br>";
                        bodyContent += "<table>" + model.TableRes + "</table>";

                        bodyContent += "<b style='width:180px; display:inline-block;'>Итого</b> - " + model.PriceRes1 + "<br>";
                        bodyContent += "<b style='width:180px; display:inline-block;'>Итого</b> - " + model.PriceRes2 + "<br>";

                        //EmailServiceForCart emailService = new EmailServiceForCart();
                        //await emailService.SendEmailAsync("sonia@poli-floor.ru", "Форма - оформить заказ", bodyContent);

                        EmailService emailService = new EmailService();
                        await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма - оформить заказ", bodyContent);
                    }
                    else
                    {
                        EmailService emailService = new EmailService();
                        await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма - узнать сроки и стоимость выполнения работ", bodyContent);
                    }

                    return ViewComponent("MainLeadSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("CalcOrder", model);
        }

        [Route("CartOrder")]
        [HttpPost]
        public async Task<IActionResult> CartOrder(CartOrderView model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cart = GetCart();

                    var bodyContent = "";
                    bodyContent = "<b style='width:140px; display:inline-block;'>Страница заявки</b> - " + model.PageUrl + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Имя </b> - " + model.Name + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Почта</b> - " + model.Email + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Телефон</b> - " + model.Phone + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>Комментарий</b> - " + model.Description + "<br>";

                    bodyContent += "<b style='width:140px; display:inline-block;'>Количество</b> - " + cart.CountProducts + "<br>";
                    bodyContent += "<b style='width:140px; display:inline-block;'>На сумму</b> - " + cart.TotalSumProducts.Value.ToString("N0") + " р" + "<br>";

                    foreach (var item in cart.Items)
                    {
                        bodyContent += "<b style='width:140px; display:inline-block;'>Материал</b> - " + item.ProductName + "<br>";
                        bodyContent += "<b style='width:140px; display:inline-block;'>Количество</b> - " + item.Count + "<br>";
                        bodyContent += "<b style='width:140px; display:inline-block;'>Сумма</b> - " + item.TotalSum.Value.ToString("N0") + " р" + "<br>";
                    }

                    //EmailServiceForCart emailService = new EmailServiceForCart();
                    //await emailService.SendEmailAsync("sonia@poli-floor.ru", "Форма оформление заказа", bodyContent);

                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync("poli-floor@poli-floor.ru", "Форма оформление заказа", bodyContent);

                    _session.Clear();

                    return ViewComponent("CartSuccess");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return ViewComponent("CartOrder", model);
        }

        [Route("CartAdd")]
        public JsonResult CartAdd(int idProduct, int countProduct)
        {
            var product = _repository.GetProductAsync(idProduct).Result;
            var cart = GetCart();
            if (product != null)
            {
                var item = cart.Items.SingleOrDefault(x => x.IdProduct == idProduct);

                decimal eur = _repository.GetEurCourse("eur").Course;

                if (item != null)
                {
                    item.Count = countProduct;
                    item.TotalSum = item.Count * (item.PriceKit * eur);
                }
                else
                {
                    var cartItem = _mapper.Map<CartItem>(product);
                    cartItem.Count = countProduct;
                    cartItem.TotalSum = cartItem.Count * (cartItem.PriceKit * eur);
                    cart.Items.Add(cartItem);
                }
                SetSession(_session, "cart", cart);
            }
            return Json(cart);
        }

        [Route("CartDelete")]
        public JsonResult CartDelete(int idProduct)
        {
            var product = _repository.GetProductAsync(idProduct).Result;
            var cart = GetCart();
            if (product != null)
            {
                var item = cart.Items.SingleOrDefault(x => x.IdProduct == idProduct);
                cart.Items.Remove(item);

                SetSession(_session, "cart", cart);
            }
            return Json(cart);
        }

        [Route("CartPlus")]
        public JsonResult CartPlus(int idProduct, int countProduct)
        {
            var product = _repository.GetProductAsync(idProduct).Result;
            var cart = GetCart();
            if (product != null)
            {
                decimal eur = _repository.GetEurCourse("eur").Course;

                var item = cart.Items.SingleOrDefault(x => x.IdProduct == idProduct);

                if (item != null)
                {
                    item.Count = countProduct + 1;
                    item.TotalSum = item.Count * (item.PriceKit * eur);
                }
                else
                {
                    var cartItem = _mapper.Map<CartItem>(product);
                    cartItem.Count = countProduct;
                    cartItem.TotalSum = cartItem.Count * (cartItem.PriceKit * eur);
                    cart.Items.Add(cartItem);
                }

                SetSession(_session, "cart", cart);
            }
            return Json(cart);
        }

        [Route("CartMinus")]
        public JsonResult CartMinus(int idProduct, int countProduct, string page)
        {
            var product = _repository.GetProductAsync(idProduct).Result;
            var cart = GetCart();
            if (product != null)
            {
                decimal eur = _repository.GetEurCourse("eur").Course;

                var item = cart.Items.SingleOrDefault(x => x.IdProduct == idProduct);

                if (item != null)
                {
                    if (page != "cart")
                    {
                        if (item.Count == 2)
                        {
                            cart.Items.Remove(item);
                        }

                        if (item.Count > 2)
                        {
                            item.Count = countProduct - 1;
                            item.TotalSum = item.Count * (item.PriceKit * eur);
                        }
                    }
                    else
                    {
                        if (item.Count == 1)
                        {
                            cart.Items.Remove(item);
                        }

                        if (item.Count > 1)
                        {
                            item.Count -= 1;
                            item.TotalSum = item.Count * (item.PriceKit * eur);
                        }
                    }
                }

                SetSession(_session, "cart", cart);
            }
            return Json(cart);
        }

        [Route("News")]
        [Route("News/{alias}")]
        public async Task<IActionResult> News(string alias)
        {
            Page page = await _repository.GetPageAsync("Novosti");

            if (page == null)
                return NotFound();

            NewsView model = new NewsView
            {
                Page = page,
                ArticleCategories = await _repository.NewsCategoriesAsync(),
                Articles = await _repository.GetNewsAsync()
            };

            if (!string.IsNullOrEmpty(alias))
            {
                ArticleCategory articleCategory = await _repository.GetNewsCategoryAsync(alias);

                if (articleCategory != null)
                {
                    model.Articles = await _repository.GetNewsAsync(articleCategory.Id);
                    model.Page.SeoTitle = articleCategory.SeoTitle;
                    model.Page.SeoDescription = articleCategory.SeoDescription;
                    model.Page.SeoKeywords = articleCategory.SeoKeywords;
                    return View(model);
                }

                Article article = await _repository.GetNewsOpenAsync(alias);

                if (article != null)
                {
                    model.ArticleOpen = article;
                    model.Articles = await _repository.GetNewsTakeAsync();
                    return View("NewsOpen", model);
                }

                return NotFound();
            }

            return View(model);
        }

        [Route("Faq")]
        [Route("Faq/{alias}")]
        public async Task<IActionResult> Articles(string alias)
        {
            Page page = await _repository.GetPageAsync("Stati");

            if (page == null)
                return NotFound();

            NewsView model = new NewsView
            {
                Page = page,
                ArticleCategories = await _repository.ArticleCategoriesAsync(),
                Articles = await _repository.GetArticlesAsync()
            };

            if (!string.IsNullOrEmpty(alias))
            {
                ArticleCategory articleCategory = await _repository.GetArticleCategoryAsync(alias);

                if (articleCategory != null)
                {
                    model.Articles = await _repository.GetArticleAsync(articleCategory.Id);
                    model.Page.SeoTitle = articleCategory.SeoTitle;
                    model.Page.SeoDescription = articleCategory.SeoDescription;
                    model.Page.SeoKeywords = articleCategory.SeoKeywords;
                    return View(model);
                }

                Article article = await _repository.GetArticleOpenAsync(alias);

                if (article != null)
                {
                    model.ArticleOpen = article;
                    model.Articles = await _repository.GetArticlesTakeAsync();
                    return View("ArticleOpen", model);
                }

                return NotFound();
            }

            return View(model);
        }

        [Route("Catalog")]
        [Route("Catalog/{alias}")]
        public async Task<IActionResult> Catalog(string alias)
        {
            Page page = await _repository.GetPageAsync("Catalog");

            if (page == null)
                return NotFound();

            CatalogView model = new CatalogView
            {
                Page = page,
                ProductCategories = await _repository.ProductCategoriesAsync(),
                Products = await _repository.GetProductsAsync(),
                CartView = GetCart(),
                EUR = _repository.GetEurCourse("eur").Course
            };

            if (!string.IsNullOrEmpty(alias))
            {
                ProductCategory productCategory = await _repository.GetProductCategoryAsync(alias);

                if (productCategory != null)
                {
                    model.Products = await _repository.GetProductsAsync(productCategory.Id);
                    model.Page.SeoTitle = productCategory.SeoTitle;
                    model.Page.SeoDescription = productCategory.SeoDescription;
                    model.Page.SeoKeywords = productCategory.SeoKeywords;
                    if (string.IsNullOrEmpty(productCategory.TitleH1))
                        model.ProductCategoryH1 = productCategory.Title;
                    else
                        model.ProductCategoryH1 = productCategory.TitleH1;

                    model.ProductCategoryDesc = productCategory.Desc;

                    return View(model);
                }

                Product product = await _repository.GetProductOpenAsync(alias);

                if (product != null)
                {
                    model.ProductOpen = product;
                    model.ProductBuys = await _repository.GetProductBuysAsync(product.Id);
                    return View("CatalogOpen", model);
                }

                return NotFound();
            }

            return View(model);
        }

        [Route("Contacts")]
        public async Task<IActionResult> Contacts()
        {
            Page page = await _repository.GetPageAsync("Kontakty");

            if (page == null)
                return NotFound();

            ContactsView model = new ContactsView
            {
                Page = page,
                Contacts = await _repository.GetContactsAsync()
            };

            return View(model);
        }

        [Route("Floors")]
        public async Task<IActionResult> Floors()
        {
            Page page = await _repository.GetPageAsync("Poly-v-pomeshcheniyakh");

            if (page == null)
                return NotFound();

            FloorsView model = new FloorsView
            {
                Page = page,
                Floors = await _repository.GetFloorsAsync()
            };

            return View(model);
        }

        [Route("Floors/{alias}")]
        public async Task<IActionResult> FloorOpen(string alias)
        {
            Floor floor = await _repository.GetFloorAsync(alias);

            if (floor == null)
                return NotFound();

            Page page = await _repository.GetPageAsync("Poly-v-pomeshcheniyakh");

            if (page == null)
                return NotFound();

            FloorsView model = new FloorsView
            {
                Page = page,
                Floor = floor,
                GalleryItems = await _repository.GetGalleryItemTakeAsync(floor.AlbumId),
                Products = await _repository.GetFloorProductsAsync(floor.Id),
                CartView = GetCart(),
                Questions = await _repository.GetFloorQuestionsAsync(floor.Id),
                EUR = _repository.GetEurCourse("eur").Course
            };

            return View(model);
        }

        [Route("Gallery")]
        [Route("Gallery/{alias}")]
        public async Task<IActionResult> Gallery(string alias)
        {
            Page page = await _repository.GetPageAsync("Fotogalereya");

            if (page == null)
                return NotFound();

            GalleryView model = new GalleryView
            {
                Page = page,
                GalleryCategories = await _repository.GalleryCategoriesAsync()
            };
            model.GalleryItems = await _repository.GetGalleryCategoriesItemsAsync(model.GalleryCategories);

            if (!string.IsNullOrEmpty(alias))
            {
                GalleryCategory galleryCategory = await _repository.GetGalleryCategoryAsync(alias);

                if (galleryCategory != null)
                {
                    page.SeoTitle = galleryCategory.SeoTitle;
                    page.SeoKeywords = galleryCategory.SeoKeywords;
                    page.SeoDescription = galleryCategory.SeoDescription;

                    model.GalleryAlbums = await _repository.GetGalleryAlbumsAsync((uint)galleryCategory.Id);
                    model.SelectGalleryCategoryId = galleryCategory.Id;

                    model.GalleryItems = await _repository.GetGalleryCategoryItemsAsync(galleryCategory.Id);

                    if (!string.IsNullOrEmpty(galleryCategory.TitleH1))
                        model.GalleryH1 = galleryCategory.TitleH1;
                    else
                        model.GalleryH1 = galleryCategory.Title;
                }

                GalleryAlbum galleryAlbum = await _repository.GetGalleryAlbumAsync(alias);

                if (galleryAlbum != null)
                {
                    page.SeoTitle = galleryAlbum.SeoTitle;
                    page.SeoDescription = galleryAlbum.SeoDescription;
                    page.SeoKeywords = galleryAlbum.SeoKeywords;

                    model.GalleryAlbums = await _repository.GetGalleryAlbumsAsync(galleryAlbum.GalleryCategoryId);
                    model.SelectGalleryCategoryId = (int)galleryAlbum.GalleryCategoryId;
                    model.SelectGalleryAlbumId = galleryAlbum.Id;

                    model.GalleryItems = await _repository.GetGalleryItemAsync(galleryAlbum.Id);

                    if (!string.IsNullOrEmpty(galleryAlbum.TitleH1))
                        model.GalleryH1 = galleryAlbum.TitleH1;
                    else
                        model.GalleryH1 = galleryAlbum.Title;
                }

                if (galleryCategory == null && galleryAlbum == null)
                {
                    return NotFound();
                }
            }

            return View(model);
        }

        [Route("Projects")]
        public async Task<IActionResult> Projects()
        {
            Page page = await _repository.GetPageAsync("Nashi-proekty");

            if (page == null)
                return NotFound();

            ProjectsView model = new ProjectsView
            {
                Page = page,
                Projects = await _repository.GetProjectsAsync()
            };

            return View(model);
        }

        [Route("Projects/{alias}")]
        public async Task<IActionResult> ProjectOpen(string alias)
        {

            if (string.IsNullOrEmpty(alias))
                return NotFound();

            Project project = await _repository.GetProjectAsync(alias);

            if (project == null)
                return NotFound();

            Page page = await _repository.GetPageAsync("Nashi-proekty");

            if (page == null)
                return NotFound();

            ProjectsView model = new ProjectsView
            {
                Page = page,
                Project = project,
                GalleryItems = await _repository.GetGalleryItemAsync(project.AlbumId)
            };

            var myList = _repository.GetProjectsAsync().Result.ToList();

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Id == project.Id)
                {
                    if (i != 0)
                        model.PrevProject = myList[i - 1];

                    if (i != myList.Count - 1)
                        model.NextProject = myList[i + 1];
                }
            }

            return View(model);
        }

        [Route("Dealers")]
        public async Task<IActionResult> Regions()
        {
            Page page = await _repository.GetPageAsync("My-v-regionakh");

            if (page == null)
                return NotFound();

            RegionsView model = new RegionsView
            {
                Page = page,
                RegionCategories = await _repository.GetRegionsCategoryAsync(),
                Regions = await _repository.GetRegionsAsync()
            };

            return View(model);
        }

        [Route("Dealers/{alias}")]
        public async Task<IActionResult> RegionOpen(string alias)
        {
            if (string.IsNullOrEmpty(alias))
                return NotFound();

            Region region = await _repository.GetRegionAsync(alias);

            if (region == null)
                return NotFound();

            Page page = await _repository.GetPageAsync("My-v-regionakh");

            if (page == null)
                return NotFound();

            RegionsView model = new RegionsView
            {
                Page = page,
                Region = region,
                GalleryItems = await _repository.GetGalleryItemTakeAsync(region.AlbumId),
                Products = await _repository.GetRegionProductsAsync(region.Id),
                CartView = GetCart(),
                EUR = _repository.GetEurCourse("eur").Course
            };

            return View(model);
        }

        #region Obuchenie
        //[Route("Obuchenie")]
        //public async Task<IActionResult> Video()
        //{
        //    Page page = await _repository.GetPageAsync("Obuchenie");

        //    if (page == null)
        //        return NotFound();

        //    VideosView model = new VideosView
        //    {
        //        Page = page,
        //        Videos = await _repository.GetVideosAsync()
        //    };

        //    return View(model);
        //}

        //[Route("Obuchenie/{alias}")]
        //public async Task<IActionResult> VideoOpen(string alias)
        //{
        //    if (string.IsNullOrEmpty(alias))
        //        return NotFound();

        //    Video video = await _repository.GetVideoAsync(alias);

        //    if (video == null)
        //        return NotFound();

        //    Page page = await _repository.GetPageAsync("Obuchenie");

        //    if (page == null)
        //        return NotFound();

        //    VideosView model = new VideosView
        //    {
        //        Page = page,
        //        Video = video,
        //        Videos = await _repository.GetMainVideosAsync()
        //    };

        //    return View(model);
        //}
        #endregion

        [Route("Obuchenie")]
        [Route("Obuchenie/{alias}")]
        public async Task<IActionResult> Video(string alias)
        {
            Page page = await _repository.GetPageAsync("Obuchenie");

            if (page == null)
                return NotFound();

            VideosView model = new VideosView
            {
                Page = page,
                VideoCategories = await _repository.VideoCategoriesAsync(),
                Videos = await _repository.GetVideosAsync()
            };

            if (!string.IsNullOrEmpty(alias))
            {
                VideoCategory videoCategory = await _repository.GetVideoCategoryAsync(alias);

                if (videoCategory != null)
                {
                    model.Videos = await _repository.GetVideoAsync(videoCategory.Id);
                    model.Page.SeoTitle = videoCategory.SeoTitle;
                    model.Page.SeoDescription = videoCategory.SeoDescription;
                    model.Page.SeoKeywords = videoCategory.SeoKeywords;
                    return View(model);
                }

                Video video = await _repository.GetVideoOpenAsync(alias);

                if (video != null)
                {
                    model.Video = video;
                    model.Videos = await _repository.GetVideosTakeAsync();
                    return View("VideoOpen", model);
                }

                return NotFound();
            }

            return View(model);
        }

        [Route("Tv")]
        public async Task<IActionResult> Tv()
        {
            Page page = await _repository.GetPageAsync("My-na-tv");

            if (page == null)
                return NotFound();

            TvView model = new TvView
            {
                Page = page,
                Tvs = await _repository.GetTvsAsync()
            };

            return View(model);
        }

        [Route("Tv/{alias}")]
        public async Task<IActionResult> TvOpen(string alias)
        {
            if (string.IsNullOrEmpty(alias))
                return NotFound();

            Tv tv = await _repository.GetTvAsync(alias);

            if (tv == null)
                return NotFound();

            Page page = await _repository.GetPageAsync("My-na-tv");

            if (page == null)
                return NotFound();

            TvView model = new TvView
            {
                Page = page,
                Tv = tv,
                GalleryItems = await _repository.GetGalleryItemTakeAsync(tv.AlbumId)
            };

            var myList = _repository.GetTvsAsync().Result.ToList();

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Id == tv.Id)
                {
                    if (i != 0)
                        model.PrevTv = myList[i - 1];

                    if (i != myList.Count - 1)
                        model.NextTv = myList[i + 1];
                }
            }

            return View(model);
        }

        #region RemovePageObuchenie
        //[Route("Obuchenie")]
        //public async Task<IActionResult> Obuchenie()
        //{
        //    Page page = await _repository.GetPageAsync("Obuchenie");

        //    if (page == null)
        //        return NotFound();

        //    TvView model = new TvView
        //    {
        //        Page = page,
        //        Tvs = await _repository.GetObuchenieListAsync()
        //    };

        //    return View(model);
        //}

        //[Route("Obuchenie/{alias}")]
        //public async Task<IActionResult> ObuchenieOpen(string alias)
        //{
        //    if (string.IsNullOrEmpty(alias))
        //        return NotFound();

        //    Tv tv = await _repository.GetTvAsync(alias);

        //    if (tv == null)
        //        return NotFound();

        //    Page page = await _repository.GetPageAsync("Obuchenie");

        //    if (page == null)
        //        return NotFound();

        //    TvView model = new TvView
        //    {
        //        Page = page,
        //        Tv = tv,
        //        GalleryItems = await _repository.GetGalleryItemTakeAsync(tv.AlbumId)
        //    };

        //    var myList = _repository.GetObuchenieListAsync().Result.ToList();

        //    for (int i = 0; i < myList.Count; i++)
        //    {
        //        if (myList[i].Id == tv.Id)
        //        {
        //            if (i != 0)
        //                model.PrevTv = myList[i - 1];

        //            if (i != myList.Count - 1)
        //                model.NextTv = myList[i + 1];
        //        }
        //    }

        //    return View(model);
        //}
        #endregion

        [Route("Services")]
        public async Task<IActionResult> Services()
        {
            Page page = await _repository.GetPageAsync("Uslugi");

            if (page == null)
                return NotFound();

            ServicesView model = new ServicesView
            {
                Page = page,
                Services = await _repository.GetServicesAsync()
            };

            return View(model);
        }

        //[Route("Services/{alias}")]
        //public async Task<IActionResult> Service(string alias)
        //{
        //    if (string.IsNullOrEmpty(alias))
        //        return NotFound();

        //    Service service = await _repository.GetServiceAsync(alias);

        //    if (service == null)
        //        return NotFound();

        //    Page page = await _repository.GetPageAsync("Uslugi");

        //    if (page == null)
        //        return NotFound();

        //    ServicesView model = new ServicesView
        //    {
        //        Page = page,
        //        Services = await _repository.GetServicesAsync(),
        //        Service = service,
        //        GalleryItems = await _repository.GetGalleryItemTakeAsync(service.AlbumId),
        //        Products = await _repository.GetServiceProductsAsync(service.Id),
        //        CartView = GetCart(),
        //        Projects = await _repository.GetServiceProjectsAsync(service.Id),
        //        Floors = await _repository.GetServiceFloorsAsync(service.Id),
        //        Articles = await _repository.GetServiceQuestionsAsync(service.Id),
        //    };

        //    return View(model);
        //}

        [Route("About")]
        public async Task<IActionResult> About()
        {
            Page page = await _repository.GetPageAsync("O-nas");

            if (page == null)
                return NotFound();

            return View(page);
        }

        [Route("Cart")]
        public async Task<IActionResult> Cart()
        {
            Page page = await _repository.GetPageAsync("Korzina");

            if (page == null)
                return NotFound();

            CartPageView model = new CartPageView
            {
                Page = page,
                CartView = GetCart(),
                EUR = _repository.GetEurCourse("eur").Course
            };

            return View(model);
        }

        [Route("Calculator")]
        [Route("Calculator/{alias}")]
        [HttpGet]
        public async Task<IActionResult> Calculator(string alias)
        {
            Page page = await _repository.GetPageAsync("Kalkulyator");

            if (page == null)
                return NotFound();

            CalculatorView model = new CalculatorView
            {
                Page = page,
                CalcCategories = _repository.CalcCategories()
            };

            if (!string.IsNullOrEmpty(alias))
            {
                model.CalcCategory = _repository.GetCalcCategoryAlias(alias);
                model.CalcThicks = _repository.CalcThicks(model.CalcCategory.Id);

                ViewBag.CalcThicks = new SelectList(model.CalcThicks, "Mm", "Mm");
            }

            return View(model);
        }

        [Route("Calculator/{alias}")]
        [HttpPost]
        public async Task<IActionResult> Calculator(CalculatorView model)
        {
            Page page = await _repository.GetPageAsync("Kalkulyator");

            if (page == null)
                return NotFound();

            model.Page = page;
            model.CalcCategories = _repository.CalcCategories();
            model.CalcCategory = _repository.GetCalcCategory(model.CalcCategory.Id);
            model.CalcThicks = _repository.CalcThicks(model.CalcCategory.Id);

            ViewBag.CalcThicks = new SelectList(model.CalcThicks, "Mm", "Mm");

            model.CalcProducts = _repository.CalcProductsFilter(model.CalcCategory.Id, model.Varnish, model.Surface);

            model.EUR = _repository.GetEurCourse("eur").Course;


            foreach (var p in model.CalcProducts)
            {
                var arr = p.Kg.Split(';');
                string str = "";
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i].StartsWith(model.Thick.ToString()))
                    {
                        str = arr[i];
                        break;
                    }
                }

                if (!string.IsNullOrWhiteSpace(str))
                {
                    p.Kg = str.Substring(str.IndexOf('-') + 1);
                }
                model.AllKg += float.Parse(p.Kg, CultureInfo.InvariantCulture);

                model.TotalSum += Convert.ToDecimal(p.PrPriceKg * model.EUR) * ((Convert.ToDecimal(p.Kg, CultureInfo.InvariantCulture) / 1000) * model.Area);
            }
            return View(model);
        }

        [Route("ReviewGet")]
        public async Task<List<Review>> GetReview()
        {
            var list = await _repository.GetAllReview();
            return list;
        }
        [HttpGet("Review")]
        public async Task<IActionResult> Review()
        {
            Page page = await _repository.GetPageAsync("Otzyv");
            if (page == null)
                return NotFound();
            ReviewView model = new ReviewView
            {
                Review = await _repository.GetOnlyFalseReview()
            };


            return View(model);

        }

        [Route("ReviewPost")]
        public async Task<IActionResult> ReviewPost(ReviewView model)
        {
            // Page page = await _repository.GetPageAsync("Otzyv");
            if (ModelState.IsValid)
            {
                List<string> imgs = new List<string>();
                try
                {
                    if (model.Images != null)
                    {
                        foreach (var image in model.Images)
                        {
                            string fullPath = _appEnvironment.WebRootPath + image.FileName;

                            if (System.IO.File.Exists(fullPath))
                                System.IO.File.Delete(fullPath);

                            var path = "/uploads/" + Guid.NewGuid() + image.FileName.ToLower();
                            path = path.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty);
                            using (var stream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                            {
                                image.CopyTo(stream);
                            }

                            imgs.Add(path);
                        }
                    }


                    var review = new Review
                    {
                        City = model.City,
                        Img = imgs.Count > 0 ? imgs[0] : null,
                        Img2 = imgs.Count > 1 ? imgs[1] : null,
                        Img3 = imgs.Count > 2 ? imgs[2] : null,
                        Img4 = imgs.Count > 3 ? imgs[3] : null,
                        Name = model.Name,
                        CreationData = DateTime.Now.Date,
                        Title = model.Title,
                        Rating = model.Rating,
                        IsAllowed = false
                    };
                    _repository.AddReview(review);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return RedirectToAction("Review");
        }
    }
}