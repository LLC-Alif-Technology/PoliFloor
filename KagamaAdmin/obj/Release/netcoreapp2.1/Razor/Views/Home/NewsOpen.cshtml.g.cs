#pragma checksum "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsOpen), @"mvc.1.0.view", @"/Views/Home/NewsOpen.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewsOpen.cshtml", typeof(AspNetCore.Views_Home_NewsOpen))]
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
#line 1 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaModels.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc4", @"/Views/Home/NewsOpen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsOpen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.NewsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("all text_white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#line 3 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
  
    ViewData["SeoTitle"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoTitle) ? Model.Page.SeoTitle : Model.ArticleOpen.SeoTitle;
    ViewData["SeoKeywords"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoKeywords) ? Model.Page.SeoKeywords : Model.ArticleOpen.SeoKeywords;
    ViewData["SeoDescription"] = string.IsNullOrEmpty(Model.ArticleOpen.SeoDescription) ? Model.Page.SeoDescription : Model.ArticleOpen.SeoDescription;

#line default
#line hidden
            BeginContext(471, 25, true);
            WriteLiteral("<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(496, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc46532", async() => {
                BeginContext(559, 7, true);
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
            BeginContext(570, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(576, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc48628", async() => {
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
            BeginContext(617, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(623, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc49885", async() => {
                BeginContext(687, 80, false);
#line 11 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
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
            BeginContext(772, 37, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"news-page\">\r\n");
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("    <div class=\"articles-filter\">\r\n        ");
            EndContext();
            BeginContext(972, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc412404", async() => {
                BeginContext(1057, 3, true);
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
            BeginContext(1064, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
         foreach (var item in Model.ArticleCategories)
        {

#line default
#line hidden
            BeginContext(1133, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1145, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc414883", async() => {
                BeginContext(1219, 10, false);
#line 20 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
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
#line 20 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
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
            BeginContext(1233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
        }

#line default
#line hidden
            BeginContext(1246, 120, true);
            WriteLiteral("    </div>\r\n    <div class=\"news-flex\">\r\n        <div class=\"news\">\r\n            <div class=\"img\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1366, "\"", 1402, 1);
#line 26 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
WriteAttributeValue("", 1372, Model.ArticleOpen.ImgOpenPage, 1372, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1403, "\"", 1409, 0);
            EndWriteAttribute();
            BeginContext(1410, 35, true);
            WriteLiteral(">\r\n                <p class=\"date\">");
            EndContext();
            BeginContext(1446, 55, false);
#line 27 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
                           Write(Model.ArticleOpen.CreationDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 81, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"ck-edit\">\r\n                <h1>");
            EndContext();
            BeginContext(1584, 101, false);
#line 30 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
                Write(string.IsNullOrEmpty(Model.ArticleOpen.TitleH1) ? Model.ArticleOpen.Title : Model.ArticleOpen.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(1686, 23, true);
            WriteLiteral("</h1>\r\n                ");
            EndContext();
            BeginContext(1710, 39, false);
#line 31 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
           Write(Html.Raw(Model.ArticleOpen.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 75, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <ul class=\"list last-news\">\r\n");
            EndContext();
#line 35 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
             foreach (var item in Model.Articles)
            {

#line default
#line hidden
            BeginContext(1890, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(1932, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d3d0a2d22c2f8f8db25cb01b7d0c331baadbc420272", async() => {
                BeginContext(2005, 42, true);
                WriteLiteral("\r\n                        <div class=\"img\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 2047, "\"", 2088, 4);
                WriteAttributeValue("", 2055, "background-image:", 2055, 17, true);
                WriteAttributeValue(" ", 2072, "url(", 2073, 5, true);
#line 39 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
WriteAttributeValue("", 2077, item.Img, 2077, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 2086, ");", 2086, 2, true);
                EndWriteAttribute();
                BeginContext(2089, 47, true);
                WriteLiteral(">\r\n                            <p class=\"date\">");
                EndContext();
                BeginContext(2137, 42, false);
#line 40 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
                                       Write(item.CreationDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(2179, 81, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <p class=\"caption\">");
                EndContext();
                BeginContext(2261, 10, false);
#line 42 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
                                      Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2271, 76, true);
                WriteLiteral("</p>\r\n                        <p class=\"desc\">\r\n                            ");
                EndContext();
                BeginContext(2348, 13, false);
#line 44 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2361, 52, true);
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
#line 38 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
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
            BeginContext(2417, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 48 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
            }

#line default
#line hidden
            BeginContext(2457, 89, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"questions-tab\" class=\"questions-tab\">\r\n    ");
            EndContext();
            BeginContext(2547, 43, false);
#line 54 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
Write(await Component.InvokeAsync("QuestionsTab"));

#line default
#line hidden
            EndContext();
            BeginContext(2590, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2603, 38, false);
#line 57 "C:\Users\Admin\Documents\Github\PoliFloor\KagamaAdmin\Views\Home\NewsOpen.cshtml"
Write(await Component.InvokeAsync("MainMap"));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 2, true);
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
