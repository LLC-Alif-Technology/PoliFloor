#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785751a0fe7e2d82eb7fa1a8b31b3e03ba38b015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_cp_Views_Shared_Components_FloorProducts_Default), @"mvc.1.0.view", @"/Areas/cp/Views/Shared/Components/FloorProducts/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/cp/Views/Shared/Components/FloorProducts/Default.cshtml", typeof(AspNetCore.Areas_cp_Views_Shared_Components_FloorProducts_Default))]
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
#line 1 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785751a0fe7e2d82eb7fa1a8b31b3e03ba38b015", @"/Areas/cp/Views/Shared/Components/FloorProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da4120c58fa967aaa0bd19f88f8d683210ac998", @"/Areas/cp/Views/_ViewImports.cshtml")]
    public class Areas_cp_Views_Shared_Components_FloorProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaAdmin.Areas.cp.ViewModels.Floor.AddProductView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/cp/img/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-table btn-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Floor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FloorProductDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "cp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(74, 163, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 12 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
           int i = 1;

#line default
#line hidden
            BeginContext(261, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 13 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
         foreach (var c in Model)
    {

#line default
#line hidden
            BeginContext(303, 33, true);
            WriteLiteral("        <tr>\r\n            <td><i>");
            EndContext();
            BeginContext(338, 3, false);
#line 16 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
               Write(i++);

#line default
#line hidden
            EndContext();
            BeginContext(342, 27, true);
            WriteLiteral("</i></td>\r\n            <td>");
            EndContext();
            BeginContext(370, 7, false);
#line 17 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
           Write(c.Title);

#line default
#line hidden
            EndContext();
            BeginContext(377, 101, true);
            WriteLiteral("</td>\r\n            <td class=\"td_btns\">\r\n                <div class=\"wrap-btn\">\r\n                    ");
            EndContext();
            BeginContext(478, 257, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35330bbacd0f427da5a73dc43f7e1a89", async() => {
                BeginContext(638, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(664, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "198cf4271044464380fea087f2f3ddfe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(702, 29, true);
                WriteLiteral("Удалить\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
                                                                                                                                  WriteLiteral(c.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 20 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
                                                                                                                                                            WriteLiteral(c.FloorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["floorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-floorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["floorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(735, 60, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Areas\cp\Views\Shared\Components\FloorProducts\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(802, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaAdmin.Areas.cp.ViewModels.Floor.AddProductView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
