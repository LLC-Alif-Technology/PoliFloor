#pragma checksum "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4332c78ce70d62646c80b5e85157f9c21dc91983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Obuchenie), @"mvc.1.0.view", @"/Views/Home/Obuchenie.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Obuchenie.cshtml", typeof(AspNetCore.Views_Home_Obuchenie))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4332c78ce70d62646c80b5e85157f9c21dc91983", @"/Views/Home/Obuchenie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Obuchenie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.TvView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ObuchenieOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(211, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(238, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cfbcd3ca8944f8a931f8fd1ccdd3e54", async() => {
                BeginContext(301, 7, true);
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
            BeginContext(312, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(318, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2bd107773eee44c9bc225c0d5f0f2b89", async() => {
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
            BeginContext(359, 9, true);
            WriteLiteral("\r\n    <a>");
            EndContext();
            BeginContext(370, 80, false);
#line 12 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
   Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(451, 47, true);
            WriteLiteral("</a>\r\n</div>\r\n\r\n<div class=\"tv-page\">\r\n    <h1>");
            EndContext();
            BeginContext(500, 80, false);
#line 16 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
    Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(581, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 17 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
     if (Model.Tvs.Any())
    {

#line default
#line hidden
            BeginContext(622, 27, true);
            WriteLiteral("        <ul class=\"list\">\r\n");
            EndContext();
#line 20 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
             foreach (var tv in Model.Tvs)
            {

#line default
#line hidden
            BeginContext(708, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(750, 519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3999f3e5e8e4b80a70f0af03c05d5bd", async() => {
                BeginContext(873, 78, true);
                WriteLiteral("\r\n                        <div class=\"info\">\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 951, "\"", 965, 1);
#line 25 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
WriteAttributeValue("", 957, tv.Icon, 957, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(966, 57, true);
                WriteLiteral(" alt=\"\">\r\n                            <p class=\"caption\">");
                EndContext();
                BeginContext(1024, 10, false);
#line 26 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
                                          Write(tv.Caption);

#line default
#line hidden
                EndContext();
                BeginContext(1034, 51, true);
                WriteLiteral("</p>\r\n                            <p class=\"title\">");
                EndContext();
                BeginContext(1086, 8, false);
#line 27 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
                                        Write(tv.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1094, 50, true);
                WriteLiteral("</p>\r\n                            <p class=\"desc\">");
                EndContext();
                BeginContext(1145, 11, false);
#line 28 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
                                       Write(tv.SubTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1156, 109, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"arrow\"></div>\r\n                    ");
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
#line 23 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
                                                                             WriteLiteral(tv.Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 837, "background-image:", 837, 17, true);
            AddHtmlAttributeValue(" ", 854, "url(", 855, 5, true);
#line 23 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
AddHtmlAttributeValue("", 859, tv.Banner, 859, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 869, ");", 869, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1269, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 33 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
            }

#line default
#line hidden
            BeginContext(1309, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 35 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
    }

#line default
#line hidden
            BeginContext(1331, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(1342, 38, false);
#line 38 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Obuchenie.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.TvView> Html { get; private set; }
    }
}
#pragma warning restore 1591
