#pragma checksum "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ecff532a9e1adf9eb9de6e1df36076f067d82a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\AlifTech\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "D:\AlifTech\KagamaAdmin\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ecff532a9e1adf9eb9de6e1df36076f067d82a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f178e43f036298d8fda4253f835f9f902367c944", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaModels.Entities.Page>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainSoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MainCalc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
  
    ViewData["SeoTitle"] = Model.SeoTitle;
    ViewData["SeoKeywords"] = Model.SeoKeywords;
    ViewData["SeoDescription"] = Model.SeoDescription;

#line default
#line hidden
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(197, 41, false);
#line 9 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainBanner"));

#line default
#line hidden
            EndContext();
            BeginContext(238, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(243, 44, false);
#line 11 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainMaterials"));

#line default
#line hidden
            EndContext();
            BeginContext(287, 61, true);
            WriteLiteral("\r\n\r\n<div class=\"main-description\">\r\n    <div class=\"ck-edit\">");
            EndContext();
            BeginContext(349, 27, false);
#line 14 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
                    Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(376, 18, true);
            WriteLiteral("</div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(395, 42, false);
#line 17 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainGallery"));

#line default
#line hidden
            EndContext();
            BeginContext(437, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(442, 43, false);
#line 19 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainProjects"));

#line default
#line hidden
            EndContext();
            BeginContext(485, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(490, 44, false);
#line 21 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainQuestions"));

#line default
#line hidden
            EndContext();
            BeginContext(534, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(539, 41, false);
#line 23 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainFloors"));

#line default
#line hidden
            EndContext();
            BeginContext(580, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(584, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6ecff532a9e1adf9eb9de6e1df36076f067d82a6446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(611, 47, true);
            WriteLiteral("\r\n\r\n<div class=\"main-lead\" id=\"mainLead\">\r\n    ");
            EndContext();
            BeginContext(659, 39, false);
#line 28 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainLead"));

#line default
#line hidden
            EndContext();
            BeginContext(698, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(710, 28, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6ecff532a9e1adf9eb9de6e1df36076f067d82a8082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(743, 39, false);
#line 33 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("MainNews"));

#line default
#line hidden
            EndContext();
            BeginContext(782, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(787, 38, false);
#line 35 "D:\AlifTech\KagamaAdmin\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaModels.Entities.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
