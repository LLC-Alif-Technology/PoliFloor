#pragma checksum "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ca735eae70d0f5f71397e2b6606e46bfb0463e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainQuestions_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainQuestions/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainQuestions/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainQuestions_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ca735eae70d0f5f71397e2b6606e46bfb0463e", @"/Views/Shared/Components/MainQuestions/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainQuestions_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KagamaModels.Entities.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(73, 272, true);
            WriteLiteral(@"    <div class=""main-qna"">
        <h1 style=""margin-bottom:17px"">Ответы на вопросы</h1>
        <p class=""subtitle"">Ответы на часто задаваемые вопросы</p>

        <div class=""content"">
            <div class=""accord"">
                <div class=""accord-wrapper"">
");
            EndContext();
#line 11 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(418, 147, true);
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"question\">\r\n                                <div class=\"value\">");
            EndContext();
            BeginContext(566, 10, false);
#line 15 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
                                              Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(576, 608, true);
            WriteLiteral(@"</div>
                                <div class=""arrow"">
                                    <svg width=""40"" height=""20"" viewBox=""0 0 44 25"" fill=""none""
                                xmlns=""http://www.w3.org/2000/svg"">
                                        <path d=""M2 2L22 22L42 2"" stroke=""#5D6A1E"" stroke-width=""3"" />
                                    </svg>
                                </div>
                            </div>
                            <div class=""answer"">
                                <h4 style=""color:#627600"">Ответ</h4>
                                <div>");
            EndContext();
            BeginContext(1185, 13, false);
#line 25 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
                                Write(item.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 76, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 28 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(1297, 94, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"footer\">\r\n                ");
            EndContext();
            BeginContext(1391, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ca735eae70d0f5f71397e2b6606e46bfb0463e7703", async() => {
                BeginContext(1457, 51, true);
                WriteLiteral("\r\n                    все вопросы\r\n                ");
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
            BeginContext(1512, 1361, true);
            WriteLiteral(@"
                <div class=""button"" id=""qna-modal-button"">
                    <svg width=""23"" height=""35"" viewBox=""0 0 23 35"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <path
                        d=""M10.656 23.808H14.208C14.208 16.944 22.992 16.56 22.992 8.352C22.992 3.216 18.672 0 11.952 0C6.576 0 2.592 1.824 0 4.992L2.544 6.912C4.656 4.368 7.632 3.024 11.712 3.024C16.608 3.024 19.44 5.424 19.44 8.88C19.44 15.168 10.656 15.888 10.656 23.808ZM12.432 34.128C13.872 34.128 14.976 32.976 14.976 31.632C14.976 30.24 13.872 29.184 12.432 29.184C11.04 29.184 9.936 30.24 9.936 31.632C9.936 32.976 11.04 34.128 12.432 34.128Z""
                        fill=""white"" />
                    </svg>
                    <a style=""margin-left: 1rem"">задать свой вопрос</a>
                </div>
            </div>
        </div>
    </div>
    <div class=""main-qna-modal"" id=""main-qna-modal"">
        <div class=""main-qna-modal-black-fon"" id=""main-qna-modal-black-fon""></div>
        <");
            WriteLiteral(@"div class=""main-qna-modal-contain"">
            <div class=""main-qna-modal-close"" id=""main-qna-modal-close""></div>
            <div class=""main-qna-modal-info"">
                <h3>Ответьте на 5 простых вопросов и получите 5 бесплатных бонусов</h3>
            </div>
            <div class=""main-qna-modal-input"">
                ");
            EndContext();
            BeginContext(2873, 1751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27ca735eae70d0f5f71397e2b6606e46bfb0463e11280", async() => {
                BeginContext(2879, 1738, true);
                WriteLiteral(@"
                    <div class=""main-qna-modal-user-info"">
                        <div>
                            <input type=""text"" id=""name-user"" placeholder=""Имя"" required>
                            <div class=""name-user-reqyured""></div>
                        </div>
                        <div>
                            <input type=""tel"" id=""user-phone"" placeholder=""Телефон"">
                        </div>
                        <div>
                            <input type=""email"" id=""user-mail"" placeholder=""Почта"">
                        </div>
                    </div>
                    <ul>
                        <li>
                            <label for=""Question1"">Вопрос</label>
                            <input type=""text"" placeholder=""Ответ"" id=""Question1"">
                        </li>
                        <li>
                            <label for=""Question2"">Вопрос</label>
                            <input type=""text"" placeholder=""Ответ"" id=""Question2");
                WriteLiteral(@""">
                        </li>
                        <li>
                            <label for=""Question3"">Вопрос</label>
                            <input type=""text"" placeholder=""Ответ"" id=""Question3"">
                        </li>
                        <li>
                            <label for=""Question4"">Вопрос</label>
                            <input type=""text"" placeholder=""Ответ"" id=""Question4"">
                        </li>
                        <li>
                            <label for=""Question5"">Вопрос</label>
                            <input type=""text"" placeholder=""Ответ"" id=""Question5"">
                        </li>
                    </ul>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4624, 290, true);
            WriteLiteral(@"
            </div>
            <div class=""main-qna-modal-bonus-button"">
                <div class=""main-qna-modal-bonus-button-icon""></div>
                <p>
                    Получить стоимость и 5 бонусов
                </p>
            </div>
        </div>
    </div>
");
            EndContext();
#line 99 "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainQuestions\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KagamaModels.Entities.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
