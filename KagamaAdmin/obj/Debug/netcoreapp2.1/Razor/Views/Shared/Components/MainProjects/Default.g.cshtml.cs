#pragma checksum "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179bb7ee556e9b984c13a7b6c00d348726a59052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainProjects_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainProjects/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainProjects/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainProjects_Default))]
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
#line 1 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
#line 3 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaModels.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179bb7ee556e9b984c13a7b6c00d348726a59052", @"/Views/Shared/Components/MainProjects/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainProjects_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/play-button.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/arrowLeft.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/arrowRight.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/list-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-all-projects"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(73, 226, true);
            WriteLiteral("    <div class=\"main-projects\">\r\n        <h2 style=\"margin:0\">Кейсы</h2>\r\n        <div class=\'description\'>За 12 лет выполнили и сдали более 700 объектов.</div>\r\n        <div class=\"content\">\r\n            <div class=\"cards\">\r\n");
            EndContext();
#line 9 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                 foreach (var project in Model)
                {

#line default
#line hidden
            BeginContext(367, 51, true);
            WriteLiteral("                    <div class=\"card \" data-alias=\"");
            EndContext();
            BeginContext(419, 13, false);
#line 11 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                              Write(project.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(432, 205, true);
            WriteLiteral("\">\r\n                        <div class=\"card-image\">\r\n                            <div class=\"play-content\">\r\n                                <div class=\"play-button\">\r\n                                    ");
            EndContext();
            BeginContext(637, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eecfbcd76a44e4abeb76fad5237b085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(679, 195, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text\">Смотрите видеоотзыв клиента</div>\r\n                            </div>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 874, "\"", 892, 1);
#line 19 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
WriteAttributeValue("", 880, project.Img, 880, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(893, 134, true);
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"card-title\">\r\n\r\n                            <p class=\"title\">");
            EndContext();
            BeginContext(1028, 13, false);
#line 23 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                        Write(project.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 100, true);
            WriteLiteral("</p>\r\n\r\n                            <div class=\"card-description\">\r\n                                ");
            EndContext();
            BeginContext(1142, 15, false);
#line 26 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                           Write(project.TitleH1);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 136, true);
            WriteLiteral("\r\n                            </div>\r\n                            <!-- <div cs -->\r\n                </div>\r\n                    </div>\r\n");
            EndContext();
#line 31 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1312, 294, true);
            WriteLiteral(@"
                <div class=""swiper-pagination""></div>
            </div>
            <div class=""control-bar"">
                <div class=""control-pag"">
                    <div class=""prev"" class=""button-prev"">
                        <div class=""cover""></div>
                        ");
            EndContext();
            BeginContext(1606, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec3483f6515044df8806eb9ecce357b7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1646, 394, true);
            WriteLiteral(@"
                    </div>
                    <div class='panel'>
                        <span id=""current"">1</span>
                        <span class=""slash""> / </span>
                        <span id=""total"">0</span>
                    </div>
                    <div class=""next"" class=""button-next"">
                        <div class=""cover""></div>
                        ");
            EndContext();
            BeginContext(2040, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c90886a972804b848b09326a2a577cff", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2081, 208, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"last-el\">\r\n                    <div class=\"button\">\r\n                        <div class=\"image\">\r\n                            ");
            EndContext();
            BeginContext(2289, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbb42616aa4e423f8cb316b3f96e55b6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2329, 397, true);
            WriteLiteral(@"
                        </div>
                        <div class=""text"">У меня подобная задача, Получить КП</div>
                    </div>
                    <div style=""position:relative"">
                        <a href-""#"" style=""background-color:transparent"">подробнее</a>
                    </div>
                </div>
            </div>
        </div>

        <!-- <ul>
");
            EndContext();
#line 66 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
         foreach (var project in Model)
        {

#line default
#line hidden
            BeginContext(2778, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2852, 363, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def87ae8dd734cddac6cf872d8b275c8", async() => {
                BeginContext(2935, 46, true);
                WriteLiteral("\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2981, "\"", 2999, 1);
#line 70 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
WriteAttributeValue("", 2987, project.Img, 2987, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3000, 60, true);
                WriteLiteral("/>\r\n                                        <p class=\"prop\">");
                EndContext();
                BeginContext(3061, 12, false);
#line 71 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                   Write(project.City);

#line default
#line hidden
                EndContext();
                BeginContext(3073, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(3076, 14, false);
#line 71 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                                  Write(project.Square);

#line default
#line hidden
                EndContext();
                BeginContext(3090, 65, true);
                WriteLiteral(" м2</p>\r\n                                        <p class=\"desc\">");
                EndContext();
                BeginContext(3156, 13, false);
#line 72 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                   Write(project.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3169, 42, true);
                WriteLiteral("</p>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                                                           WriteLiteral(project.Alias);

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
            BeginContext(3215, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 75 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(3267, 463, true);
            WriteLiteral(@"                    <li>
                        <a asp-action=""Projects"" asp-controller=""Home"" asp-route-alias="""" class=""all_projects"">
                            <p>
                                <span>Смотреть все <br> проекты</span>
                            </p>
                        </a>
                    </li>
                </ul> -->

    <div class=""swiper-container swiper-main-projects"">
            <div class=""swiper-wrapper"">
");
            EndContext();
#line 87 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                 foreach (var project in Model)
                {

#line default
#line hidden
            BeginContext(3798, 68, true);
            WriteLiteral("                    <div class=\"swiper- \">\r\n                        ");
            EndContext();
            BeginContext(3866, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff422defb45473ab8c22e88e3489562", async() => {
                BeginContext(3949, 34, true);
                WriteLiteral("\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3983, "\"", 4001, 1);
#line 91 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
WriteAttributeValue("", 3989, project.Img, 3989, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4002, 54, true);
                WriteLiteral(" alt=\"\">\r\n                            <p class=\"prop\">");
                EndContext();
                BeginContext(4057, 12, false);
#line 92 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                       Write(project.City);

#line default
#line hidden
                EndContext();
                BeginContext(4069, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(4072, 14, false);
#line 92 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                      Write(project.Square);

#line default
#line hidden
                EndContext();
                BeginContext(4086, 53, true);
                WriteLiteral(" м2</p>\r\n                            <p class=\"desc\">");
                EndContext();
                BeginContext(4140, 13, false);
#line 93 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                       Write(project.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4153, 30, true);
                WriteLiteral("</p>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                                                                               WriteLiteral(project.Alias);

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
            BeginContext(4187, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 96 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(4236, 95, true);
            WriteLiteral("            </div>\r\n            <div class=\"swiper-pagination\"></div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(4331, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5025c55820114ccb956bdf2c38f963fa", async() => {
                BeginContext(4420, 20, true);
                WriteLiteral("Смотреть все проекты");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4444, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 102 "C:\Users\admin\Desktop\PoliFloor_new\PoliFloor_new\KagamaAdmin\Views\Shared\Components\MainProjects\Default.cshtml"



}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaModels.Entities.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
