#pragma checksum "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84b3256ea8636029c898c4e7f47a387d6f122c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Articles), @"mvc.1.0.view", @"/Views/Home/Articles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Articles.cshtml", typeof(AspNetCore.Views_Home_Articles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84b3256ea8636029c898c4e7f47a387d6f122c9", @"/Views/Home/Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.NewsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(213, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(240, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3316f8daaf864be2aacd536d9002b100", async() => {
                BeginContext(303, 7, true);
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
            BeginContext(314, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(320, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "85b6f891e58c491e896dea1f38eac208", async() => {
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
            BeginContext(361, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
     if (ViewContext.RouteData.Values["alias"] != null)
    {

#line default
#line hidden
            BeginContext(427, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(435, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c41f5d761549e0a6a03f443401e886", async() => {
                BeginContext(503, 80, false);
#line 14 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
                                                                      Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

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
            BeginContext(588, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
    }

#line default
#line hidden
            BeginContext(597, 43, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"news-page\">\r\n    <h1>");
            EndContext();
            BeginContext(642, 80, false);
#line 19 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
    Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(723, 50, true);
            WriteLiteral("</h1>\r\n    <div class=\"articles-filter\">\r\n        ");
            EndContext();
            BeginContext(773, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0414a03a11434a34be2330e30d04176c", async() => {
                BeginContext(920, 3, true);
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
AddHtmlAttributeValue("", 846, ViewContext.RouteData.Values["alias"] == null ? "all text_white" : "", 846, 72, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(927, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
         foreach (var item in Model.ArticleCategories)
        {

#line default
#line hidden
            BeginContext(996, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1008, 262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b223150fb8441f598702bbc8f8cd7a4", async() => {
                BeginContext(1256, 10, false);
#line 24 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
                                                                                                                                                                                                                                                              Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
AddHtmlAttributeValue("", 1018, (ViewContext.RouteData.Values["alias"] != null && ViewContext.RouteData.Values["alias"].ToString().ToLower() == item.Alias.ToLower()) ? "all text_white" : "" , 1018, 161, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
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
            BeginContext(1270, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
        }

#line default
#line hidden
            BeginContext(1283, 93, true);
            WriteLiteral("        <a href=\"#questions-tab\" class=\"questions text_white\">Задать вопрос</a>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
     if (Model.Articles.Any())
    {

#line default
#line hidden
            BeginContext(1415, 27, true);
            WriteLiteral("        <ul class=\"list\">\r\n");
            EndContext();
#line 31 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
             foreach (var item in Model.Articles)
            {

#line default
#line hidden
            BeginContext(1508, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(1550, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a0b0c9a5fd44d6db2546c2a715ad16c", async() => {
                BeginContext(1627, 42, true);
                WriteLiteral("\r\n                        <div class=\"img\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 1669, "\"", 1710, 4);
                WriteAttributeValue("", 1677, "background-image:", 1677, 17, true);
                WriteAttributeValue(" ", 1694, "url(", 1695, 5, true);
#line 35 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
WriteAttributeValue("", 1699, item.Img, 1699, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 1708, ");", 1708, 2, true);
                EndWriteAttribute();
                BeginContext(1711, 47, true);
                WriteLiteral(">\r\n                            <p class=\"date\">");
                EndContext();
                BeginContext(1759, 42, false);
#line 36 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
                                       Write(item.CreationDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1801, 81, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <p class=\"caption\">");
                EndContext();
                BeginContext(1883, 10, false);
#line 38 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
                                      Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1893, 76, true);
                WriteLiteral("</p>\r\n                        <p class=\"desc\">\r\n                            ");
                EndContext();
                BeginContext(1970, 13, false);
#line 40 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1983, 52, true);
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
#line 34 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
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
            BeginContext(2039, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 44 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
            }

#line default
#line hidden
            BeginContext(2079, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 46 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
    }

#line default
#line hidden
            BeginContext(2101, 62, true);
            WriteLiteral("</div>\r\n\r\n<div id=\"questions-tab\" class=\"questions-tab\">\r\n    ");
            EndContext();
            BeginContext(2164, 43, false);
#line 50 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
Write(await Component.InvokeAsync("QuestionsTab"));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2220, 38, false);
#line 53 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Articles.cshtml"
Write(await Component.InvokeAsync("MainMap"));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 2, true);
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
