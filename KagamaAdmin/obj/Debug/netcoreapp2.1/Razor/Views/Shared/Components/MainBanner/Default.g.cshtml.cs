<<<<<<< HEAD
#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a1ac7b75fe80110048d218c7866e2d21841525c"
=======
#pragma checksum "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21570cb9199967f17a3ef274be024cdd874ccaf6"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
#line 1 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1ac7b75fe80110048d218c7866e2d21841525c", @"/Views/Shared/Components/MainBanner/Default.cshtml")]
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
<<<<<<< HEAD
#line 2 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
 if (ViewContext.RouteData.Values["action"].ToString() == "Service" && ViewContext.RouteData.Values["alias"] == null)
{
}
else
=======
#line 2 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
 if (Model.Any())
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
{

#line default
#line hidden
            BeginContext(185, 28, true);
            WriteLiteral("    <div class=\"main-banner\"");
            EndContext();
<<<<<<< HEAD
            BeginWriteAttribute("style", " style=\"", 213, "\"", 266, 4);
            WriteAttributeValue("", 221, "background-image:", 221, 17, true);
            WriteAttributeValue(" ", 238, "url(", 239, 5, true);
#line 7 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 243, Model.First().Banner, 243, 21, false);
=======
            BeginWriteAttribute("style", " style=\"", 101, "\"", 154, 4);
            WriteAttributeValue("", 109, "background-image:", 109, 17, true);
            WriteAttributeValue(" ", 126, "url(", 127, 5, true);
#line 4 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 131, Model.First().Banner, 131, 21, false);
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333

#line default
#line hidden
            WriteAttributeValue("", 264, ");", 264, 2, true);
            EndWriteAttribute();
            BeginContext(267, 214, true);
            WriteLiteral(">\r\n        <div class=\"main-background-opacity\"></div>\r\n        <div class=\"swiper-container\" id=\"swiper-container\">\r\n                <div class=\"swiper-wrapper\">\r\n                    <div class=\"main-swiper-video\"");
            EndContext();
<<<<<<< HEAD
            BeginWriteAttribute("style", " style=\"", 481, "\"", 534, 4);
            WriteAttributeValue("", 489, "background-image:", 489, 17, true);
            WriteAttributeValue(" ", 506, "url(", 507, 5, true);
#line 11 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 511, Model.First().Banner, 511, 21, false);
=======
            BeginWriteAttribute("style", " style=\"", 369, "\"", 422, 4);
            WriteAttributeValue("", 377, "background-image:", 377, 17, true);
            WriteAttributeValue(" ", 394, "url(", 395, 5, true);
#line 8 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
WriteAttributeValue("", 399, Model.First().Banner, 399, 21, false);
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333

#line default
#line hidden
            WriteAttributeValue("", 532, ");", 532, 2, true);
            EndWriteAttribute();
            BeginContext(535, 777, true);
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
<<<<<<< HEAD
#line 29 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 26 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                  
                                    int index = 0;
                                        

#line default
#line hidden
<<<<<<< HEAD
#line 31 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 28 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                         foreach (var item in Model)
                                        {
                                            index++;
                                            if (index <= 5)
                                            {

#line default
#line hidden
            BeginContext(1675, 106, true);
            WriteLiteral("                                                <li>\r\n                                                    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(1781, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0e6bd06a0b34cc89a4ad1cbe8178715", async() => {
                BeginContext(1855, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(1914, 10, false);
#line 38 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
            BeginContext(1669, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "827566615bd04655a2a1f03d9d9f978e", async() => {
                BeginContext(1743, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(1802, 10, false);
#line 35 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                                   Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1924, 54, true);
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
<<<<<<< HEAD
#line 37 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 34 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
            BeginContext(1982, 57, true);
            WriteLiteral("\r\n                                                </li>\r\n");
            EndContext();
<<<<<<< HEAD
#line 41 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 38 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                            }
                                        }

#line default
#line hidden
            BeginContext(2164, 290, true);
            WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""sentence-reference-data"">
                            <div class=""sentence-before"">
                            </div>
                            <p>
                                ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2454, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a78a0e2822254b398b46a9adaa37e534", async() => {
                BeginContext(2518, 124, true);
=======
            BeginContext(2342, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "495769b644bd45b78bffe5858280a7d0", async() => {
                BeginContext(2406, 124, true);
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
            BeginContext(2646, 379, true);
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
<<<<<<< HEAD
#line 63 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 60 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                          
                            int mobiIndex = 0;
                            

#line default
#line hidden
<<<<<<< HEAD
#line 65 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 62 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                             foreach (var item in Model)
                            {
                                mobiIndex++;
                                if (mobiIndex <= 5)
                                {

#line default
#line hidden
            BeginContext(3324, 82, true);
            WriteLiteral("                                    <li>\r\n                                        ");
            EndContext();
<<<<<<< HEAD
            BeginContext(3406, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e45537d91748ed9e88a81e6cec627f", async() => {
                BeginContext(3480, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3527, 10, false);
#line 72 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
            BeginContext(3294, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e31d28fa24194931987f00ba11376a52", async() => {
                BeginContext(3368, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3415, 10, false);
#line 69 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                       Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3537, 42, true);
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
<<<<<<< HEAD
#line 71 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 68 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
            BeginContext(3583, 45, true);
            WriteLiteral("\r\n                                    </li>\r\n");
            EndContext();
<<<<<<< HEAD
#line 75 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 72 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
                                }
                            }

#line default
#line hidden
            BeginContext(3721, 469, true);
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
<<<<<<< HEAD
            BeginContext(4190, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1922f214e95743ea89c17f11e39aba3f", async() => {
                BeginContext(4254, 108, true);
=======
            BeginContext(4078, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0681f769829246a8899d3c120423a86d", async() => {
                BeginContext(4142, 108, true);
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
            BeginContext(4366, 728, true);
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
<<<<<<< HEAD
#line 114 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
=======
#line 111 "C:\Users\admin\Desktop\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainBanner\Default.cshtml"
>>>>>>> 8fbfbd7eab0ab85d209300a945cc8ef1ba277333
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
