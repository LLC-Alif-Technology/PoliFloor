#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542bba88fe9820e5a9f93fefb12728513cf39f22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacts.cshtml", typeof(AspNetCore.Views_Home_Contacts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542bba88fe9820e5a9f93fefb12728513cf39f22", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.ContactsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/bread.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Regions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
  
    ViewData["SeoTitle"] = Model.Page.SeoTitle;
    ViewData["SeoKeywords"] = Model.Page.SeoKeywords;
    ViewData["SeoDescription"] = Model.Page.SeoDescription;

#line default
#line hidden
            BeginContext(217, 27, true);
            WriteLiteral("\r\n<div class=\"bread\">\r\n    ");
            EndContext();
            BeginContext(244, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69149c80704b6fa80f6274070384c3", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a286795a6ea54650962151ae9a7ef9f7", async() => {
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
            BeginContext(467, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
#line 15 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
 if (Model.Contacts.Any())
{

#line default
#line hidden
            BeginContext(508, 45, true);
            WriteLiteral("    <div class=\"contacts-page\">\r\n        <h1>");
            EndContext();
            BeginContext(555, 80, false);
#line 18 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
        Write(string.IsNullOrEmpty(Model.Page.TitleH1) ? Model.Page.Title : Model.Page.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(636, 36, true);
            WriteLiteral("</h1>\r\n        <ul class=\"cities\">\r\n");
            EndContext();
#line 20 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
             foreach (var item in Model.Contacts)
            {

#line default
#line hidden
            BeginContext(738, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 760, "\"", 788, 1);
#line 22 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
WriteAttributeValue("", 767, item.UrltoPageRegion, 767, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(789, 20, true);
            WriteLiteral(" class=\"scroll_tab\">");
            EndContext();
            BeginContext(810, 10, false);
#line 22 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(820, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(823, 36, false);
#line 22 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                                                               Write(item.IsMain ? "(Головной офис)" : "");

#line default
#line hidden
            EndContext();
            BeginContext(860, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 23 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
            }

#line default
#line hidden
            BeginContext(886, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(902, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a768fcbe224f38872792e44eef9936", async() => {
                BeginContext(967, 23, true);
                WriteLiteral("Другие города и регионы");
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
            BeginContext(994, 22, true);
            WriteLiteral("</li>\r\n        </ul>\r\n");
            EndContext();
#line 26 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
         foreach (var item in Model.Contacts)
        {
            if (item.IsMain)
            {

#line default
#line hidden
            BeginContext(1119, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1139, "\"", 1156, 1);
#line 30 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
WriteAttributeValue("", 1144, item.Anchor, 1144, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1157, 46, true);
            WriteLiteral(" class=\"city main-city\">\r\n                    ");
            EndContext();
            BeginContext(1204, 22, false);
#line 31 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
               Write(Html.Raw(item.CodeMap));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                     if (string.IsNullOrEmpty(item.UrltoPageRegion))
                    {

#line default
#line hidden
            BeginContext(1321, 43, true);
            WriteLiteral("                        <p class=\"caption\">");
            EndContext();
            BeginContext(1365, 10, false);
#line 34 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1453, 45, true);
            WriteLiteral("                        <p class=\"caption\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1526, 1);
#line 38 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
WriteAttributeValue("", 1505, item.UrltoPageRegion, 1505, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1527, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1529, 10, false);
#line 38 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 39 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                    }

#line default
#line hidden
            BeginContext(1572, 220, true);
            WriteLiteral("                    <ul class=\"main-city-info\">\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/schedule.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(1793, 13, false);
#line 43 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Schedule);

#line default
#line hidden
            EndContext();
            BeginContext(1806, 209, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/location2.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(2016, 12, false);
#line 47 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2028, 206, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/email2.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(2235, 10, false);
#line 51 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 211, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/phone-call2.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(2457, 10, false);
#line 55 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2467, 88, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n");
            EndContext();
#line 59 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2603, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2623, "\"", 2640, 1);
#line 62 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
WriteAttributeValue("", 2628, item.Anchor, 2628, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2641, 16, true);
            WriteLiteral(" class=\"city\">\r\n");
            EndContext();
#line 63 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                     if (string.IsNullOrEmpty(item.UrltoPageRegion))
                    {

#line default
#line hidden
            BeginContext(2750, 43, true);
            WriteLiteral("                        <p class=\"caption\">");
            EndContext();
            BeginContext(2794, 10, false);
#line 65 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2804, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 66 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2882, 45, true);
            WriteLiteral("                        <p class=\"caption\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2927, "\"", 2955, 1);
#line 69 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
WriteAttributeValue("", 2934, item.UrltoPageRegion, 2934, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2956, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2958, 10, false);
#line 69 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2968, 10, true);
            WriteLiteral("</a></p>\r\n");
            EndContext();
#line 70 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                    }

#line default
#line hidden
            BeginContext(3001, 216, true);
            WriteLiteral("                    <ul class=\"city-info\">\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/schedule2.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(3218, 13, false);
#line 74 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Schedule);

#line default
#line hidden
            EndContext();
            BeginContext(3231, 209, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/location3.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(3441, 12, false);
#line 78 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3453, 206, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/email3.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(3660, 10, false);
#line 82 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3670, 211, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                        <li>\r\n                            <div class=\"img\" style=\"background-image: url(/client/img/phone-call3.png);\"></div>\r\n                            <p>");
            EndContext();
            BeginContext(3882, 10, false);
#line 86 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                          Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(3892, 132, true);
            WriteLiteral("</p>\r\n                        </li>\r\n                    </ul>\r\n                    <div class=\"city-map\">\r\n                        ");
            EndContext();
            BeginContext(4025, 22, false);
#line 90 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
                   Write(Html.Raw(item.CodeMap));

#line default
#line hidden
            EndContext();
            BeginContext(4047, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 93 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(4127, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 96 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
}

#line default
#line hidden
            BeginContext(4142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4145, 38, false);
#line 98 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Home\Contacts.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.ContactsView> Html { get; private set; }
    }
}
#pragma warning restore 1591
