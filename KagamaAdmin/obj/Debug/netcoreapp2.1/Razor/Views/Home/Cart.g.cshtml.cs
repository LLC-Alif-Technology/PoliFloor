#pragma checksum "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb057f2297be3a009e7342fcdf1ae71ec37b75c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb057f2297be3a009e7342fcdf1ae71ec37b75c9", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.CartPageView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/stock.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/no_stock.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/garbage.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/right-arrow3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(217, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(244, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "307189e5f4d3457884cc8cf77aae52ed", async() => {
                BeginContext(307, 7, true);
                WriteLiteral("Главная");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(324, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37a163af687e46bf9e55bf394c15d7ed", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(365, 9, true);
            WriteLiteral("\r\n    <a>");
            EndContext();
            BeginContext(376, 80, false);
#line 12 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
   Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(457, 47, true);
            WriteLiteral("</a>\r\n</div>\r\n<div class=\"cart-page\">\r\n    <h1>");
            EndContext();
            BeginContext(506, 80, false);
#line 15 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
    Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(587, 36, true);
            WriteLiteral("</h1>\r\n    <div class=\"cart-flex\">\r\n");
            EndContext();
#line 17 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
         if (Model.CartView.Items.Any())
        {

#line default
#line hidden
            BeginContext(676, 36, true);
            WriteLiteral("            <ul class=\"cart-list\">\r\n");
            EndContext();
#line 20 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                 foreach (var product in Model.CartView.Items)
                {

#line default
#line hidden
            BeginContext(795, 53, true);
            WriteLiteral("                    <li class=\"cartli\" data-item-id=\"");
            EndContext();
            BeginContext(849, 17, false);
#line 22 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                                Write(product.IdProduct);

#line default
#line hidden
            EndContext();
            BeginContext(866, 44, true);
            WriteLiteral("\">\r\n                        <img class=\"img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 910, "\"", 928, 1);
#line 23 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
WriteAttributeValue("", 916, product.Img, 916, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(929, 53, true);
            WriteLiteral(" alt=\"\">\r\n                        <p class=\"caption\">");
            EndContext();
            BeginContext(983, 19, false);
#line 24 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                      Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 80, true);
            WriteLiteral("</p>\r\n                        <p class=\"price\">\r\n                            <b>");
            EndContext();
            BeginContext(1084, 51, false);
#line 26 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                           Write((product.PriceKit * Model.EUR).Value.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 165, true);
            WriteLiteral(" р.</b> шт.\r\n                        </p>\r\n                        <div class=\"counter counterIsCart\">\r\n                            <span class=\"plus\" data-item-id=\"");
            EndContext();
            BeginContext(1302, 17, false);
#line 29 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                                        Write(product.IdProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 84, true);
            WriteLiteral("\" data-page=\"cart\"></span>\r\n                            <input type=\"number\" min=\"1\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1403, "\"", 1425, 1);
#line 30 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1411, product.Count, 1411, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1426, 65, true);
            WriteLiteral(">\r\n                            <span class=\"minus\" data-item-id=\"");
            EndContext();
            BeginContext(1492, 17, false);
#line 31 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                                         Write(product.IdProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 140, true);
            WriteLiteral("\" data-page=\"cart\"></span>\r\n                        </div>\r\n                        <p class=\"price\">\r\n                            <b><span>");
            EndContext();
            BeginContext(1650, 37, false);
#line 34 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                Write(product.TotalSum.Value.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 93, true);
            WriteLiteral("</span> р.</b> шт.\r\n                        </p>\r\n                        <p class=\"stock\">\r\n");
            EndContext();
#line 37 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                             if (product.Stock)
                            {

#line default
#line hidden
            BeginContext(1860, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1892, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a11e6c75d7e048918f60394fc5df0843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1933, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2031, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2063, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db03a129887a495c8104a72700914e6a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                            }

#line default
#line hidden
            BeginContext(2140, 128, true);
            WriteLiteral("                            <span>Есть в наличии</span>\r\n                        </p>\r\n                        <a data-product=\"");
            EndContext();
            BeginContext(2269, 17, false);
#line 47 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                    Write(product.IdProduct);

#line default
#line hidden
            EndContext();
            BeginContext(2286, 37, true);
            WriteLiteral("\" class=\"delete js_CartDeleteInCart\">");
            EndContext();
            BeginContext(2323, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cbd68efe3054ce5a3a109fa1c68877a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2366, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 49 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                }

#line default
#line hidden
            BeginContext(2418, 112, true);
            WriteLiteral("            </ul>\r\n            <div class=\"cart-total\">\r\n                <p>Товаров в корзине на сумму <b><span>");
            EndContext();
            BeginContext(2531, 52, false);
#line 52 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
                                                  Write(Model.CartView.TotalSumProducts.Value.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 74, true);
            WriteLiteral("</span> руб.</b></p>\r\n                <button><span>Оформить заказ</span> ");
            EndContext();
            BeginContext(2657, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b93220108d144ba7b6b7a00d6ea590e8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2705, 31, true);
            WriteLiteral("</button>\r\n            </div>\r\n");
            EndContext();
#line 55 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
        }

#line default
#line hidden
            BeginContext(2747, 65, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"cart-order\" id=\"cartOrder\">\r\n    ");
            EndContext();
            BeginContext(2813, 40, false);
#line 59 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
Write(await Component.InvokeAsync("CartOrder"));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(2864, 38, false);
#line 61 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Home\Cart.cshtml"
Write(await Component.InvokeAsync("MainMap"));

#line default
#line hidden
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.CartPageView> Html { get; private set; }
    }
}
#pragma warning restore 1591
