#pragma checksum "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\CounterCodeBottom\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f28433b5fb2538d966f0e6820611d43c674d096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CounterCodeBottom_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CounterCodeBottom/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CounterCodeBottom/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CounterCodeBottom_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f28433b5fb2538d966f0e6820611d43c674d096", @"/Views/Shared/Components/CounterCodeBottom/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CounterCodeBottom_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Counter>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\CounterCodeBottom\Default.cshtml"
 if (Model.Any())
{
    foreach (var counter in Model)
    {
        

#line default
#line hidden
            BeginContext(127, 28, false);
#line 7 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\CounterCodeBottom\Default.cshtml"
   Write(Html.Raw(counter.CodeBottom));

#line default
#line hidden
            EndContext();
#line 7 "D:\projects\workProjects\PoliFloor\KagamaAdmin\Views\Shared\Components\CounterCodeBottom\Default.cshtml"
                                     
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaModels.Entities.Counter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
