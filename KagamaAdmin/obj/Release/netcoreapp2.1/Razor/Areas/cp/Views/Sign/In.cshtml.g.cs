#pragma checksum "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e21039e46117d5b0d961f4d5cd01db967fabf02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_cp_Views_Sign_In), @"mvc.1.0.view", @"/Areas/cp/Views/Sign/In.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/cp/Views/Sign/In.cshtml", typeof(AspNetCore.Areas_cp_Views_Sign_In))]
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
#line 1 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\_ViewImports.cshtml"
using KagamaAdmin;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\_ViewImports.cshtml"
using KagamaAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e21039e46117d5b0d961f4d5cd01db967fabf02", @"/Areas/cp/Views/Sign/In.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da4120c58fa967aaa0bd19f88f8d683210ac998", @"/Areas/cp/Views/_ViewImports.cshtml")]
    public class Areas_cp_Views_Sign_In : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KagamaAdmin.Areas.cp.ViewModels.Sign.InView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
 using (Html.BeginForm(FormMethod.Post, new { @class = "sign-form" }))
{

#line default
#line hidden
            BeginContext(129, 84, true);
            WriteLiteral("    <p class=\"page-title\">???????? ?? ?????????? ????????????</p>\r\n    <div class=\"input\">\r\n        ");
            EndContext();
            BeginContext(214, 60, false);
#line 7 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
   Write(Html.TextBoxFor(x => x.Login, new { placeholder = "??????????" }));

#line default
#line hidden
            EndContext();
            BeginContext(274, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
         if (ViewData.ModelState["Login"]?.Errors.Count > 0)
        {

#line default
#line hidden
            BeginContext(349, 29, true);
            WriteLiteral("            <i class=\"error\">");
            EndContext();
            BeginContext(379, 51, false);
#line 10 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
                        Write(ViewData.ModelState["Login"].Errors[0].ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(430, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 11 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
        }

#line default
#line hidden
            BeginContext(447, 45, true);
            WriteLiteral("    </div>\r\n    <div class=\"input\">\r\n        ");
            EndContext();
            BeginContext(493, 65, false);
#line 14 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
   Write(Html.PasswordFor(x => x.Password, new { placeholder = "????????????" }));

#line default
#line hidden
            EndContext();
            BeginContext(558, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
         if (ViewData.ModelState["Password"]?.Errors.Count > 0)
        {

#line default
#line hidden
            BeginContext(636, 29, true);
            WriteLiteral("            <i class=\"error\">");
            EndContext();
            BeginContext(666, 54, false);
#line 17 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
                        Write(ViewData.ModelState["Password"].Errors[0].ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(720, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 18 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
        }

#line default
#line hidden
            BeginContext(737, 48, true);
            WriteLiteral("    </div>\r\n    <div class=\"checkbox\">\r\n        ");
            EndContext();
            BeginContext(786, 37, false);
#line 21 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
   Write(Html.CheckBoxFor(x => x.IsPersistent));

#line default
#line hidden
            EndContext();
            BeginContext(823, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(834, 34, false);
#line 22 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
   Write(Html.LabelFor(x => x.IsPersistent));

#line default
#line hidden
            EndContext();
            BeginContext(868, 110, true);
            WriteLiteral("\r\n        <div class=\"check\"></div>\r\n    </div>\r\n    <input type=\"submit\" value=\"??????????\" class=\"btn-primary\">\r\n");
            EndContext();
#line 26 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
     if (!ViewData.ModelState.IsValid)
    {

#line default
#line hidden
            BeginContext(1025, 27, true);
            WriteLiteral("        <div>\r\n            ");
            EndContext();
            BeginContext(1053, 28, false);
#line 29 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
    }

#line default
#line hidden
#line 31 "C:\Users\user\Desktop\Acer_KagamaAdmin\KagamaAdmin\Areas\cp\Views\Sign\In.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KagamaAdmin.Areas.cp.ViewModels.Sign.InView> Html { get; private set; }
    }
}
#pragma warning restore 1591
