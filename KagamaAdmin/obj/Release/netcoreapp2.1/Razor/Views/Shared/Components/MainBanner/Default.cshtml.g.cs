#pragma checksum "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b13b26bec2f2a897f897013013784373999281"
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
#line 1 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
#line 3 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaModels.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b13b26bec2f2a897f897013013784373999281", @"/Views/Shared/Components/MainBanner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainBanner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
 if (ViewContext.RouteData.Values["action"].ToString() != "Service" && ViewContext.RouteData.Values["alias"] == null)
{ 

#line default
#line hidden
            BeginContext(174, 28, true);
            WriteLiteral("    <div class=\"main-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 202, "\"", 255, 4);
            WriteAttributeValue("", 210, "background-image:", 210, 17, true);
            WriteAttributeValue(" ", 227, "url(", 228, 5, true);
#line 4 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 232, Model.First().Banner, 232, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 253, ");", 253, 2, true);
            EndWriteAttribute();
            BeginContext(256, 214, true);
            WriteLiteral(">\r\n        <div class=\"main-background-opacity\"></div>\r\n        <div class=\"swiper-container\" id=\"swiper-container\">\r\n                <div class=\"swiper-wrapper\">\r\n                    <div class=\"main-swiper-video\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 470, "\"", 523, 4);
            WriteAttributeValue("", 478, "background-image:", 478, 17, true);
            WriteAttributeValue(" ", 495, "url(", 496, 5, true);
#line 8 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 500, Model.First().Banner, 500, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 521, ");", 521, 2, true);
            EndWriteAttribute();
            BeginContext(524, 369, true);
            WriteLiteral(@">
                        <div class=""main-swiper-video-action"">
                            <div class=""main-swiper-video-action-button"">
                            </div>
                            <p>
                                Смотрите видеоотзыв клиента
                            </p>
                        </div>
                        <iframe");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 893, "\"", 898, 0);
            EndWriteAttribute();
            BeginContext(899, 402, true);
            WriteLiteral(@">
                            Test
                        </iframe>
                    </div>
                    <div class=""reference-data"">
                        <div class=""keys-reference-data"">
                            <h2>
                                Производим и монтируем всю линейку бесшовных полов ключ:
                            </h2>
                            <ul>
");
            EndContext();
#line 26 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                  
                                    int index = 0;
                                        

#line default
#line hidden
#line 28 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                         foreach (var item in Model)
                                        {
                                            index++;
                                            if (index <= 5)
                                            {

#line default
#line hidden
            BeginContext(1664, 106, true);
            WriteLiteral("                                                <li>\r\n                                                    ");
            EndContext();
            BeginContext(1770, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b13b26bec2f2a897f8970130137843739992818299", async() => {
                BeginContext(1844, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(1903, 10, false);
#line 35 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1913, 54, true);
                WriteLiteral("\r\n                                                    ");
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
#line 34 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(1971, 57, true);
            WriteLiteral("\r\n                                                </li>\r\n");
            EndContext();
#line 38 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(2153, 290, true);
            WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""sentence-reference-data"">
                            <div class=""sentence-before"">
                            </div>
                            <p>
                                ");
            EndContext();
            BeginContext(2443, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b13b26bec2f2a897f89701301378437399928112178", async() => {
                BeginContext(2507, 124, true);
                WriteLiteral("\r\n                                    Получить коммерческое предложение в течение 14 часов\r\n                                ");
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
            BeginContext(2635, 379, true);
            WriteLiteral(@"
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
#line 60 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                          
                            int mobiIndex = 0;
                            

#line default
#line hidden
#line 62 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                             foreach (var item in Model)
                            {
                                mobiIndex++;
                                if (mobiIndex <= 5)
                                {

#line default
#line hidden
            BeginContext(3313, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(3395, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b13b26bec2f2a897f89701301378437399928115608", async() => {
                BeginContext(3469, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3516, 10, false);
#line 69 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3526, 42, true);
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
#line 68 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(3572, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 72 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3710, 469, true);
            WriteLiteral(@"                    </ul>
                </div>
                <div class=""main-swiper-video-action"">
                    <div class=""main-swiper-video-action-button""></div>
                    <p>
                        Смотрите видеоотзыв клиента
                    </p>
                </div>
                <div class=""sentence-reference-data"">
                    <div class=""sentence-before""></div>
                    <p>
                        ");
            EndContext();
            BeginContext(4179, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4b13b26bec2f2a897f89701301378437399928119587", async() => {
                BeginContext(4243, 108, true);
                WriteLiteral("\r\n                            Получить коммерческое предложение в течение 14 часов\r\n                        ");
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
            BeginContext(4355, 728, true);
            WriteLiteral(@"
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
                        2020 цветов на выбор и вкус
                    </p>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 111 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
}
else
{
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
