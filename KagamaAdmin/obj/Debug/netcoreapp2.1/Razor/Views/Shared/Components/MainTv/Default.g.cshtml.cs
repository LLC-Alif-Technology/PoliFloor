#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d594807970d3c4a1932724cb3fa296dcf25c8edb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainTv_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainTv/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainTv/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainTv_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d594807970d3c4a1932724cb3fa296dcf25c8edb", @"/Views/Shared/Components/MainTv/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainTv_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Tv>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TvOpen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 326, true);
            WriteLiteral(@"
<div class=""tv-page"">

    <h1 style=""margin-bottom: 1rem"">МЫ НА ТВ</h1>
    <h4>На постоянной основе выступаем в качестве эксперта и партнера на ТВ-передачах</h4>
    <div class=""tv-page-cards"">
        <div class=""slider-lists-prev"" id=""sliderListsPrev""></div>
        <div class=""slider-lists"" id=""tvScrollLists"">
");
            EndContext();
#line 10 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
             if (Model.Any())
            {
                var Card = 0;


#line default
#line hidden
            BeginContext(451, 54, true);
            WriteLiteral("                <ul class=\"tv_lists\" id=\"UnListsTv\">\r\n");
            EndContext();
#line 15 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                     foreach (var tv in Model)
                    {
                        Card++;
                        if (Card <= 8)
                        {

#line default
#line hidden
            BeginContext(676, 100, true);
            WriteLiteral("                            <li>\r\n                                <div class=\"tv-lists-contain-list\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 776, "\"", 818, 4);
            WriteAttributeValue("", 784, "background-image:", 784, 17, true);
            WriteAttributeValue(" ", 801, "url(", 802, 5, true);
#line 21 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
WriteAttributeValue("", 806, tv.Banner, 806, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 816, ");", 816, 2, true);
            EndWriteAttribute();
            BeginContext(819, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(858, 981, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b531fe40a19f4b019c3578148fcdd10c", async() => {
                BeginContext(931, 184, true);
                WriteLiteral("\r\n                                        <div class=\"tv_lists-info\">\r\n                                            <p class=\"caption\">\r\n                                                ");
                EndContext();
                BeginContext(1116, 10, false);
#line 25 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                                           Write(tv.Caption);

#line default
#line hidden
                EndContext();
                BeginContext(1126, 163, true);
                WriteLiteral("\r\n                                            </p>\r\n                                            <p class=\"title\">\r\n                                                ");
                EndContext();
                BeginContext(1290, 8, false);
#line 28 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                                           Write(tv.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1298, 310, true);
                WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div class=""tv-lists-navigation-bottom"">
                                            <div class=""info-img-contain"">
                                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1608, "\"", 1622, 1);
#line 33 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
WriteAttributeValue("", 1614, tv.Icon, 1614, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1623, 212, true);
                WriteLiteral(" />\r\n                                            </div>\r\n                                            <div class=\"arrow\"></div>\r\n                                        </div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-alias", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                                                                                      WriteLiteral(tv.Alias);

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
            BeginContext(1839, 77, true);
            WriteLiteral("\r\n                                </div>\r\n                            </li>\r\n");
            EndContext();
#line 40 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1966, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
#line 43 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2004, 156, true);
            WriteLiteral("        </div>\r\n        <div class=\"slider-lists-next\" id=\"sliderListsNext\"></div>\r\n    </div>\r\n    <div class=\"slider-select-card\" id=\"sliderSelectCard\">\r\n");
            EndContext();
#line 48 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
          
            int Index = 0;
            

#line default
#line hidden
#line 50 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
             foreach (var tv in Model)
            {
                Index++;
                if (Index <= 8)
                {   

#line default
#line hidden
            BeginContext(2336, 56, true);
            WriteLiteral("                    <input type=\"radio\" name=\"card\" />\r\n");
            EndContext();
#line 56 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\MainTv\Default.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2437, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaModels.Entities.Tv>> Html { get; private set; }
    }
}
#pragma warning restore 1591
