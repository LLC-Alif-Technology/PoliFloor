#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7853b7a4ad8bbcaf4f9bd35e396a6efbfaf535ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Projects), @"mvc.1.0.view", @"/Views/Home/Projects.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Projects.cshtml", typeof(AspNetCore.Views_Home_Projects))]
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
#line 1 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7853b7a4ad8bbcaf4f9bd35e396a6efbfaf535ed", @"/Views/Home/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.ProjectsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(217, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(244, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ce14028c1ca410b87dcf753ec3d1810", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8315f08a21644f20bd484cba95b4d2c2", async() => {
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
            BeginContext(365, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(467, 47, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"projects-page\">\r\n    <h1>");
            EndContext();
            BeginContext(516, 80, false);
#line 16 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
    Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(597, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 17 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
     if (Model.Projects.Any())
    {

#line default
#line hidden
            BeginContext(643, 27, true);
            WriteLiteral("        <ul class=\"list\">\r\n");
            EndContext();
#line 20 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
             foreach (var item in Model.Projects)
            {

#line default
#line hidden
            BeginContext(736, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(778, 2103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5aa1a258e0f46b0a7be28d2947df299", async() => {
                BeginContext(902, 91, true);
                WriteLiteral("\r\n                        <div class=\"info\">\r\n                            <p class=\"title\">");
                EndContext();
                BeginContext(994, 10, false);
#line 25 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                        Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1004, 40, true);
                WriteLiteral("</p>\r\n                            <ul>\r\n");
                EndContext();
#line 27 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                 if (!string.IsNullOrEmpty(item.Square))
                                {

#line default
#line hidden
                BeginContext(1153, 300, true);
                WriteLiteral(@"                                <li>
                                    <div class=""img"" style=""background-image: url(client/img/projects_page_icon_1.png);""></div>
                                    <p>
                                        Площадь
                                        <b>");
                EndContext();
                BeginContext(1454, 11, false);
#line 33 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                      Write(item.Square);

#line default
#line hidden
                EndContext();
                BeginContext(1465, 103, true);
                WriteLiteral(" <span>м2</span></b>\r\n                                    </p>\r\n                                </li>\r\n");
                EndContext();
#line 36 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                }

#line default
#line hidden
                BeginContext(1603, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 37 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                 if (!string.IsNullOrEmpty(item.City))
                                {

#line default
#line hidden
                BeginContext(1710, 298, true);
                WriteLiteral(@"                                <li>
                                    <div class=""img"" style=""background-image: url(client/img/projects_page_icon_2.png);""></div>
                                    <p>
                                        Город
                                        <b>");
                EndContext();
                BeginContext(2009, 9, false);
#line 43 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                      Write(item.City);

#line default
#line hidden
                EndContext();
                BeginContext(2018, 87, true);
                WriteLiteral("</b>\r\n                                    </p>\r\n                                </li>\r\n");
                EndContext();
#line 46 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                }

#line default
#line hidden
                BeginContext(2140, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 47 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                 if (item.Price != null)
                                {

#line default
#line hidden
                BeginContext(2233, 339, true);
                WriteLiteral(@"                                    <li>
                                        <div class=""img"" style=""background-image: url(client/img/projects_page_icon_3.png);""></div>
                                        <p>
                                            Стоимость материалов на м2
                                            <b>");
                EndContext();
                BeginContext(2573, 31, false);
#line 53 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                          Write(item.Price.Value.ToString("N0"));

#line default
#line hidden
                EndContext();
                BeginContext(2604, 100, true);
                WriteLiteral(" руб.</b>\r\n                                        </p>\r\n                                    </li>\r\n");
                EndContext();
#line 56 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                }

#line default
#line hidden
                BeginContext(2739, 138, true);
                WriteLiteral("                            </ul>\r\n                        </div>\r\n                        <div class=\"arrow\"></div>\r\n                    ");
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
#line 23 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
                                                                           WriteLiteral(item.Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 865, "background-image:url(", 865, 21, true);
#line 23 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
AddHtmlAttributeValue("", 886, item.Banner, 886, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 898, ");", 898, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2881, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 62 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
            }

#line default
#line hidden
            BeginContext(2921, 15, true);
            WriteLiteral("        </ul>\r\n");
            EndContext();
#line 64 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
    }

#line default
#line hidden
            BeginContext(2943, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(2954, 38, false);
#line 67 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Projects.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.ProjectsView> Html { get; private set; }
    }
}
#pragma warning restore 1591
