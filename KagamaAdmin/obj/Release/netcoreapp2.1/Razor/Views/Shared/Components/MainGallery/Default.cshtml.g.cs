#pragma checksum "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainGallery\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a34ba32ed02defae4b5199c91fb564ad0d69b32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainGallery_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainGallery/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainGallery/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainGallery_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a34ba32ed02defae4b5199c91fb564ad0d69b32", @"/Views/Shared/Components/MainGallery/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainGallery_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.ViewModel.MainGalleryView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 116, true);
            WriteLiteral("\r\n<div class=\"main-gallery\">\r\n        <div class=\"main-gallery-info\">\r\n            <div class=\"gallery-description\">");
            EndContext();
            BeginContext(163, 40, false);
#line 5 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainGallery\Default.cshtml"
                                        Write(Html.Raw(Model.GalleryAlbum.Description));

#line default
#line hidden
            EndContext();
            BeginContext(203, 98, true);
            WriteLiteral("</div>\r\n            <div class=\"gallery-description\">\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(302, 25, false);
#line 8 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainGallery\Default.cshtml"
               Write(Html.Raw(Model.VideoDesc));

#line default
#line hidden
            EndContext();
            BeginContext(327, 68, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.ViewModel.MainGalleryView> Html { get; private set; }
    }
}
#pragma warning restore 1591
