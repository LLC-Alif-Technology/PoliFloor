#pragma checksum "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f4484d087bb5f9f15f5693aa283e096e55c25c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticleOpen), @"mvc.1.0.view", @"/Views/Home/ArticleOpen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ArticleOpen.cshtml", typeof(AspNetCore.Views_Home_ArticleOpen))]
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
#line 1 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4484d087bb5f9f15f5693aa283e096e55c25c8", @"/Views/Home/ArticleOpen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ArticleOpen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.NewsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("all text_white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
  
    var h1 = string.IsNullOrEmpty(Model.ArticleOpen.TitleH1) ? Model.ArticleOpen.Title : Model.ArticleOpen.TitleH1;
    ViewData["SeoTitle"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoTitle) ? "Интересно знать: " + h1 : Model.ArticleOpen.SeoTitle;
    ViewData["SeoKeywords"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoKeywords) ? Model.Page.SeoKeywords : Model.ArticleOpen.SeoKeywords;
    ViewData["SeoDescription"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoDescription) ? "Часто задаваемые вопросы и полезные статьи: " + h1 + " читать на Поли-флоор." : Model.ArticleOpen.SeoDescription;

#line default
#line hidden
            BeginContext(646, 25, true);
            WriteLiteral("<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(671, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ce3781a8d53478db5cd75cfe410ef5f", async() => {
                BeginContext(734, 7, true);
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
            BeginContext(745, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(751, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f4bae1fbc2f4621b9bc532bb8773675", async() => {
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
            BeginContext(792, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(798, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6c4159675424ed59c3266cd863ea706", async() => {
                BeginContext(866, 80, false);
#line 12 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                                                  Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            BeginContext(951, 37, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"news-page\">\r\n");
            EndContext();
            BeginContext(1108, 43, true);
            WriteLiteral("    <div class=\"articles-filter\">\r\n        ");
            EndContext();
            BeginContext(1151, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bba647b1d0b740358d35df274e66f9dc", async() => {
                BeginContext(1240, 3, true);
                WriteLiteral("Все");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1247, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
         foreach (var item in Model.ArticleCategories)
        {

#line default
#line hidden
            BeginContext(1316, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1328, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2a8356753b4cf4be63ab49c4bb8ece", async() => {
                BeginContext(1406, 10, false);
#line 21 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                                                                    Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                                                WriteLiteral(item.Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1420, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
        }

#line default
#line hidden
            BeginContext(1433, 201, true);
            WriteLiteral("        <a href=\"#questions-tab\" class=\"questions text_white\">Задать вопрос</a>\r\n    </div>\r\n    <div class=\"news-flex\">\r\n        <div class=\"news\">\r\n            <div class=\"img\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1634, "\"", 1670, 1);
#line 28 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
WriteAttributeValue("", 1640, Model.ArticleOpen.ImgOpenPage, 1640, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1671, 42, true);
            WriteLiteral(" alt=\"\">\r\n                <p class=\"date\">");
            EndContext();
            BeginContext(1714, 55, false);
#line 29 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                           Write(Model.ArticleOpen.CreationDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 81, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"ck-edit\">\r\n                <h1>");
            EndContext();
            BeginContext(1852, 2, false);
#line 32 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                Write(h1);

#line default
#line hidden
            EndContext();
            BeginContext(1855, 23, true);
            WriteLiteral("</h1>\r\n                ");
            EndContext();
            BeginContext(1879, 39, false);
#line 33 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
           Write(Html.Raw(Model.ArticleOpen.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 75, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <ul class=\"list last-news\">\r\n");
            EndContext();
#line 37 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
             foreach (var item in Model.Articles)
            {

#line default
#line hidden
            BeginContext(2059, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(2101, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5d6de7f79574eb7888c30dce88eb4c1", async() => {
                BeginContext(2178, 42, true);
                WriteLiteral("\r\n                        <div class=\"img\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 2220, "\"", 2261, 4);
                WriteAttributeValue("", 2228, "background-image:", 2228, 17, true);
                WriteAttributeValue(" ", 2245, "url(", 2246, 5, true);
#line 41 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
WriteAttributeValue("", 2250, item.Img, 2250, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 2259, ");", 2259, 2, true);
                EndWriteAttribute();
                BeginContext(2262, 47, true);
                WriteLiteral(">\r\n                            <p class=\"date\">");
                EndContext();
                BeginContext(2310, 42, false);
#line 42 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                       Write(item.CreationDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(2352, 81, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <p class=\"caption\">");
                EndContext();
                BeginContext(2434, 10, false);
#line 44 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                      Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2444, 76, true);
                WriteLiteral("</p>\r\n                        <p class=\"desc\">\r\n                            ");
                EndContext();
                BeginContext(2521, 13, false);
#line 46 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2534, 52, true);
                WriteLiteral("\r\n                        </p>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
                                                                        WriteLiteral(item.Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2590, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 50 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
            }

#line default
#line hidden
            BeginContext(2630, 89, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"questions-tab\" class=\"questions-tab\">\r\n    ");
            EndContext();
            BeginContext(2720, 43, false);
#line 56 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
Write(await Component.InvokeAsync("QuestionsTab"));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2776, 38, false);
#line 59 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\ArticleOpen.cshtml"
Write(await Component.InvokeAsync("MainMap"));

#line default
#line hidden
            EndContext();
            BeginContext(2814, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.NewsView> Html { get; private set; }
    }
}
#pragma warning restore 1591