#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95f8eed799989edf349f4247246c7f73b052a8b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainBanner_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainBanner/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainBanner/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainBanner_Default))]
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
#line 3 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaModels.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95f8eed799989edf349f4247246c7f73b052a8b9", @"/Views/Shared/Components/MainBanner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainBanner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
 if (ViewContext.RouteData.Values["action"].ToString() != "Service" && ViewContext.RouteData.Values["action"].ToString()
!= "Index" && ViewContext.RouteData.Values["alias"] == null)
{

#line default
#line hidden
            BeginContext(238, 46, true);
            WriteLiteral("    <div class=\"main-banner main-banner-other\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 284, "\"", 337, 4);
            WriteAttributeValue("", 292, "background-image:", 292, 17, true);
            WriteAttributeValue(" ", 309, "url(", 310, 5, true);
#line 5 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 314, Model.First().Banner, 314, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 335, ");", 335, 2, true);
            EndWriteAttribute();
            BeginContext(338, 193, true);
            WriteLiteral(">\r\n        <div class=\"main-background-opacity-others\"></div>\r\n        <div class=\"swiper-container\" id=\"swiper-container\">\r\n            <div class=\"main-banner-others\">\r\n                <ul>\r\n");
            EndContext();
#line 10 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(604, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 631, "\"", 675, 4);
            WriteAttributeValue("", 639, "background-image:", 639, 17, true);
            WriteAttributeValue(" ", 656, "url(", 657, 5, true);
#line 12 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 661, item.Banner, 661, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 673, ");", 673, 2, true);
            EndWriteAttribute();
            BeginContext(676, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(707, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa0fe035437499b9900b509e37a5780", async() => {
                BeginContext(782, 10, false);
#line 13 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                                                                                 Write(item.Title);

#line default
#line hidden
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
            BeginWriteTagHelperAttribute();
#line 13 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(796, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 15 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(852, 302, true);
            WriteLiteral(@"                </ul>
            </div>
            <div class=""mobi-swiper-wrapper"">
                <div class=""keys-reference-data"">
                    <h2>
                        Производим и монтируем всю линейку бесшовных полов ключ:
                    </h2>
                    <ul>
");
            EndContext();
#line 24 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                          
                            int mobiIndex = 0;
                            

#line default
#line hidden
#line 26 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                             foreach (var item in Model)
                            {
                                mobiIndex++;
                                if (mobiIndex <= 5)
                                {

#line default
#line hidden
            BeginContext(1453, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(1535, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7df9fffe79e94488bb245529fd6794e3", async() => {
                BeginContext(1609, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(1656, 10, false);
#line 33 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1666, 42, true);
                WriteLiteral("\r\n                                        ");
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
            BeginWriteTagHelperAttribute();
#line 32 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(1712, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 36 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(1850, 169, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"main-swiper-video-action\">\r\n                    <a class=\"main-swiper-video-action-button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2019, "\"", 2050, 1);
#line 42 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 2026, Model.First().LinkVideo, 2026, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2051, 1221, true);
            WriteLiteral(@"></a>
                    <p>
                        Смотрите видеоотзыв клиента
                    </p>
                </div>
                <div class=""sentence-reference-data js-open-order"">
                    <div class=""sentence-before""></div>
                    <p>
                        <a>
                            Получить коммерческое предложение в течение 14 часов
                        </a>
                    </p>
                </div>
                <div class=""main-bottom-static-items"">
                    <div class=""item before-url1"">
                        <p>
                            Воплощаем самые сложные задачи дизайна в реальности
                        </p>
                    </div>
                    <div class=""item before-url2"">
                        <p>
                            Опыт укладки полов более 13 лет
                        </p>
                    </div>
                    <div class=""item before-url3"">
                   ");
            WriteLiteral("     <p>\r\n                            2020 цветов на выбор и вкус\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 75 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
}

#line default
#line hidden
#line 76 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
 if (ViewContext.RouteData.Values["action"].ToString() == "Index" && ViewContext.RouteData.Values["alias"] == null)
{

#line default
#line hidden
            BeginContext(3395, 28, true);
            WriteLiteral("    <div class=\"main-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3423, "\"", 3476, 4);
            WriteAttributeValue("", 3431, "background-image:", 3431, 17, true);
            WriteAttributeValue(" ", 3448, "url(", 3449, 5, true);
#line 78 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 3453, Model.First().Banner, 3453, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3474, ");", 3474, 2, true);
            EndWriteAttribute();
            BeginContext(3477, 603, true);
            WriteLiteral(@">
        <div class=""main-background-opacity""></div>
        <div class=""swiper-container"" id=""swiper-container"">
            <div class=""swiper-wrapper"">
                <div class=""main-swiper-video"">
                    <div class=""main-swiper-video-action"">
                        <a class=""main-swiper-video-action-button"" id=""main-swiper-video-action-button"">
                        </a>
                        <p>
                            Смотрите видеоотзыв клиента
                        </p>
                    </div>
                    <div class=""main-swiper-video-fon""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4080, "\"", 4133, 4);
            WriteAttributeValue("", 4088, "background-image:", 4088, 17, true);
            WriteAttributeValue(" ", 4105, "url(", 4106, 5, true);
#line 90 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 4110, Model.First().Banner, 4110, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4131, ");", 4131, 2, true);
            EndWriteAttribute();
            BeginContext(4134, 31, true);
            WriteLiteral(">\r\n                    </div>\r\n");
            EndContext();
#line 92 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                     if (@Model.First().LinkVideo != null)
                    {

#line default
#line hidden
            BeginContext(4248, 31, true);
            WriteLiteral("                        <iframe");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4279, "\"", 4309, 1);
#line 94 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 4285, Model.First().LinkVideo, 4285, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4310, 68, true);
            WriteLiteral(" id=\"main-swiper-video-iframe\">\r\n                        </iframe>\r\n");
            EndContext();
#line 96 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4450, 90, true);
            WriteLiteral("                        <div class=\"main-swiper-video-Error\" id=\"main-swiper-video-iframe\"");
            EndContext();
            BeginWriteAttribute("style", "\r\n                    style=\"", 4540, "\"", 4614, 4);
            WriteAttributeValue("", 4569, "background-image:", 4569, 17, true);
            WriteAttributeValue(" ", 4586, "url(", 4587, 5, true);
#line 100 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 4591, Model.First().Banner, 4591, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4612, ");", 4612, 2, true);
            EndWriteAttribute();
            BeginContext(4615, 96, true);
            WriteLiteral(">\r\n                            Пока тут нет видеоотзыв клиента\r\n                        </div>\r\n");
            EndContext();
#line 103 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(4734, 302, true);
            WriteLiteral(@"                </div>
                <div class=""reference-data"">
                    <div class=""keys-reference-data"">
                        <h2>
                            Производим и монтируем всю линейку бесшовных полов ключ:
                        </h2>
                        <ul>
");
            EndContext();
#line 111 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                              
                                int index = 0;
                                

#line default
#line hidden
#line 113 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                 foreach (var item in Model)
                                {
                                    index++;
                                    if (index <= 5)
                                    {

#line default
#line hidden
            BeginContext(5351, 90, true);
            WriteLiteral("                                        <li>\r\n                                            ");
            EndContext();
            BeginContext(5441, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d651b2d8ce4db2a6160cb60c1fa1ac", async() => {
                BeginContext(5515, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(5566, 10, false);
#line 120 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                           Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(5576, 46, true);
                WriteLiteral("\r\n                                            ");
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
            BeginWriteTagHelperAttribute();
#line 119 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(5626, 49, true);
            WriteLiteral("\r\n                                        </li>\r\n");
            EndContext();
#line 123 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(5780, 762, true);
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""sentence-reference-data js-open-order"">
                        <div class=""sentence-before"">
                        </div>
                        <p>
                            <a>
                                Получить коммерческое предложение в течение 14 часов
                            </a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""mobi-swiper-wrapper"">
                <div class=""keys-reference-data"">
                    <h2>
                        Производим и монтируем всю линейку бесшовных полов ключ:
                    </h2>
                    <ul>
");
            EndContext();
#line 145 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                          
                            int mobiIndex = 0;
                            

#line default
#line hidden
#line 147 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                             foreach (var item in Model)
                            {
                                mobiIndex++;
                                if (mobiIndex <= 5)
                                {

#line default
#line hidden
            BeginContext(6841, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(6923, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9818f5b8808743bf8de212e895688037", async() => {
                BeginContext(6997, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(7044, 10, false);
#line 154 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(7054, 42, true);
                WriteLiteral("\r\n                                        ");
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
            BeginWriteTagHelperAttribute();
#line 153 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(7100, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 157 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(7238, 169, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"main-swiper-video-action\">\r\n                    <a class=\"main-swiper-video-action-button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7407, "\"", 7438, 1);
#line 163 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 7414, Model.First().LinkVideo, 7414, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7439, 1153, true);
            WriteLiteral(@"></a>
                    <p>
                        Смотрите видеоотзыв клиента
                    </p>
                </div>
                <div class=""sentence-reference-data js-open-order"">
                    <div class=""sentence-before""></div>
                    <p>
                        <a>
                            Получить коммерческое предложение в течение 14 часов
                        </a>
                    </p>
                </div>
            </div>
            <div class=""main-bottom-static-items"">
                <div class=""item before-url1"">
                    <p>
                        Воплощаем самые сложные задачи дизайна в реальности
                    </p>
                </div>
                <div class=""item before-url2"">
                    <p>
                        Опыт укладки полов более 13 лет
                    </p>
                </div>
                <div class=""item before-url3"">
                    <p>
                      ");
            WriteLiteral("  2020 цветов на выбор и вкус\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 196 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaModels.Entities.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
