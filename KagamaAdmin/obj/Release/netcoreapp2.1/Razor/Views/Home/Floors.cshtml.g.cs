#pragma checksum "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "533b32279a34ff4ccecc813651e964dc4ca4097c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Floors), @"mvc.1.0.view", @"/Views/Home/Floors.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Floors.cshtml", typeof(AspNetCore.Views_Home_Floors))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"533b32279a34ff4ccecc813651e964dc4ca4097c", @"/Views/Home/Floors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Floors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.FloorsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FloorOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(215, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(242, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "095bdd5d5d384cad97e8b4095f1ac85a", async() => {
                BeginContext(305, 7, true);
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
            BeginContext(316, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(322, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f090c1f50d64dc59099892eee69d5d8", async() => {
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
            BeginContext(363, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(465, 57, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"main-floors page-floors\">\r\n    <h1>");
            EndContext();
            BeginContext(524, 80, false);
#line 16 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
    Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(605, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 17 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
     if (Model.Floors.Any())
    {

#line default
#line hidden
            BeginContext(649, 14, true);
            WriteLiteral("        <ul>\r\n");
            EndContext();
#line 20 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
             foreach (var item in Model.Floors)
            {

#line default
#line hidden
            BeginContext(727, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(769, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264ae65342e04b50bfdfde2705843552", async() => {
                BeginContext(847, 42, true);
                WriteLiteral("\r\n                        <div class=\"img\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 889, "\"", 931, 4);
                WriteAttributeValue("", 897, "background-image:", 897, 17, true);
                WriteAttributeValue(" ", 914, "url(", 915, 5, true);
#line 24 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
WriteAttributeValue("", 919, item.Icon, 919, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 929, ");", 929, 2, true);
                EndWriteAttribute();
                BeginContext(932, 36, true);
                WriteLiteral("></div>\r\n                        <p>");
                EndContext();
                BeginContext(969, 10, false);
#line 25 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
                      Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(979, 26, true);
                WriteLiteral("</p>\r\n                    ");
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
#line 23 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
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
            BeginContext(1009, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 28 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
            }

#line default
#line hidden
            BeginContext(1049, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 30 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
    }

#line default
#line hidden
            BeginContext(1071, 25, true);
            WriteLiteral("    <div class=\"ck-edit\">");
            EndContext();
            BeginContext(1097, 32, false);
#line 31 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
                    Write(Html.Raw(Model.Page.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
            EndContext();
            BeginContext(1146, 38, false);
#line 33 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Views\Home\Floors.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.FloorsView> Html { get; private set; }
    }
}
#pragma warning restore 1591
