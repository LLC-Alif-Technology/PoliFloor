#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21570cb9199967f17a3ef274be024cdd874ccaf6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21570cb9199967f17a3ef274be024cdd874ccaf6", @"/Views/Shared/Components/MainBanner/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainBanner_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(73, 28, true);
            WriteLiteral("    <div class=\"main-banner\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 101, "\"", 154, 4);
            WriteAttributeValue("", 109, "background-image:", 109, 17, true);
            WriteAttributeValue(" ", 126, "url(", 127, 5, true);
#line 4 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 131, Model.First().Banner, 131, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 152, ");", 152, 2, true);
            EndWriteAttribute();
            BeginContext(155, 214, true);
            WriteLiteral(">\r\n        <div class=\"main-background-opacity\"></div>\r\n        <div class=\"swiper-container\" id=\"swiper-container\">\r\n                <div class=\"swiper-wrapper\">\r\n                    <div class=\"main-swiper-video\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 369, "\"", 422, 4);
            WriteAttributeValue("", 377, "background-image:", 377, 17, true);
            WriteAttributeValue(" ", 394, "url(", 395, 5, true);
#line 8 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 399, Model.First().Banner, 399, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 420, ");", 420, 2, true);
            EndWriteAttribute();
            BeginContext(423, 777, true);
            WriteLiteral(@">
                        <div class=""main-swiper-video-action"">
                            <div class=""main-swiper-video-action-button"">
                            </div>
                            <p>
                                Смотрите видеоотзыв клиента
                            </p>
                        </div>
                        <iframe id="""">
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
#line 26 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                  
                                    int index = 0;
                                        

#line default
#line hidden
#line 28 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                         foreach (var item in Model)
                                        {
                                            index++;
                                            if (index <= 5)
                                            {

#line default
#line hidden
            BeginContext(1563, 106, true);
            WriteLiteral("                                                <li>\r\n                                                    ");
            EndContext();
            BeginContext(1669, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f89a854f5ff64c31886fb74c14bd3b66", async() => {
                BeginContext(1743, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(1802, 10, false);
#line 35 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1812, 54, true);
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
#line 34 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(1870, 57, true);
            WriteLiteral("\r\n                                                </li>\r\n");
            EndContext();
#line 38 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(2052, 290, true);
            WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""sentence-reference-data"">
                            <div class=""sentence-before"">
                            </div>
                            <p>
                                ");
            EndContext();
            BeginContext(2342, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb9e496e114410da9b9b486a6aec0d3", async() => {
                BeginContext(2406, 124, true);
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
            BeginContext(2534, 379, true);
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
#line 60 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                          
                            int mobiIndex = 0;
                            

#line default
#line hidden
#line 62 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                             foreach (var item in Model)
                            {
                                mobiIndex++;
                                if (mobiIndex <= 5)
                                {

#line default
#line hidden
            BeginContext(3212, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
            BeginContext(3294, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdbdebbfb0644ad980f653c0ae66209", async() => {
                BeginContext(3368, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3415, 10, false);
#line 69 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3425, 42, true);
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
#line 68 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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
            BeginContext(3471, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
#line 72 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3609, 469, true);
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
            BeginContext(4078, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339ce1a59c2a492dbd4e2d3e6a67ed40", async() => {
                BeginContext(4142, 108, true);
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
            BeginContext(4254, 728, true);
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
#line 111 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
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