#pragma checksum "C:\Users\Admin\Documents\Github\PoliFloor\PoliFloor\KagamaAdmin\Views\Shared\Components\MainCalculator\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3089e3c31c7864c25a9e583d877fd382e999a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MainCalculator_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MainCalculator/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MainCalculator/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MainCalculator_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3089e3c31c7864c25a9e583d877fd382e999a0c", @"/Views/Shared/Components/MainCalculator/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dacd68af6debffd15778304c53d74c21cdea7ff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MainCalculator_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/client/img/static.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 648, true);
            WriteLiteral(@"<div class=""main-calculator"">
    <div class=""content"">
        <h1>Узнайте стоимость услуг и материалов</h1>
        <div class=""control-bar"">
            <div class=""input-section"">
                <div class=""title"">Площадь</div>
                <div class=""input-label"">
                    <input type=""text"" />
                    <span>м<sup>2</sup></span>
                </div>
            </div>
            <div class=""input-section"">
                <div class=""title"">Толщина</div>
                <div class=""input-label"">
                    <input type=""text"" />
                    <select>
                        ");
            EndContext();
            BeginContext(648, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3089e3c31c7864c25a9e583d877fd382e999a0c4834", async() => {
                BeginContext(656, 2, true);
                WriteLiteral("мм");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(667, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(693, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3089e3c31c7864c25a9e583d877fd382e999a0c6027", async() => {
                BeginContext(701, 2, true);
                WriteLiteral("см");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(712, 1249, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""input-section"">
                <div class=""title"">Лак</div>
                <div class=""radios"">
                    <div class=""label"" style=""margin-right: 12px;"">
                        <div class=""radio""> 
                            <input type=""radio"" name=""lak"" id=""matoviy""  />
                        </div>
                        <label for=""matoviy"">Матовый</label>
                    </div>
                    <div class=""label"">
                        <div class=""radio""> 
                            <input type=""radio"" name=""lak"" id=""glyantseviy""  />
                        </div>  
                        <label for=""glyantseviy"">Глянцевый</label>
                    </div>
                </div>
            </div>
        </div>
        <div class=""services"">
            <div class=""services-wrapper"">
                <div class=""service"" tabindex=""1"">
                    <d");
            WriteLiteral("iv class=\"decoration\" id=\"dt\"></div>\r\n                    <div class=\"top\">\r\n                        <div class=\"text\">Декоративные эпоксидные полы</div>\r\n                    </div>\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1961, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c8534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1998, 521, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                <div class=""service"" tabindex=""1"">
                    <div class=""decoration"" id=""dt""></div>
                    <div class=""top"">
                        <div class=""text"">Декоративные эпоксидные полы</div>
                    </div>
                    
                    ");
            EndContext();
            BeginContext(2519, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c10244", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2556, 521, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                <div class=""service"" tabindex=""1"">
                    <div class=""decoration"" id=""dt""></div>
                    <div class=""top"">
                        <div class=""text"">Декоративные эпоксидные полы</div>
                    </div>
                    
                    ");
            EndContext();
            BeginContext(3077, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c11955", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3114, 521, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                <div class=""service"" tabindex=""1"">
                    <div class=""decoration"" id=""dt""></div>
                    <div class=""top"">
                        <div class=""text"">Декоративные эпоксидные полы</div>
                    </div>
                    
                    ");
            EndContext();
            BeginContext(3635, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c13666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3672, 521, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                <div class=""service"" tabindex=""1"">
                    <div class=""decoration"" id=""dt""></div>
                    <div class=""top"">
                        <div class=""text"">Декоративные эпоксидные полы</div>
                    </div>
                    
                    ");
            EndContext();
            BeginContext(4193, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c15377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4230, 521, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                <div class=""service"" tabindex=""1"">
                    <div class=""decoration"" id=""dt""></div>
                    <div class=""top"">
                        <div class=""text"">Декоративные эпоксидные полы</div>
                    </div>
                    
                    ");
            EndContext();
            BeginContext(4751, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3089e3c31c7864c25a9e583d877fd382e999a0c17088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4788, 2732, true);
            WriteLiteral(@"
                    <div class=""bottom"">
                        <div class=""text"">Узнать стоимость</div>
                    </div>
                    <div class=""decoration"" id=""db""></div>
                </div>
                
            </div>
        </div>
    </div>
    <div class=""result"">
        <table>
            <thead>
                <tr>
                    <th>Наименование</th>
                    <th>Реком-й расход на 1 м2 (кг)</th>
                    <th>Необх-е кол-во (кг)</th>
                    <th>Цена на 1 м2 (руб.)</th>
                    <th>Всего</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Промышленный, эпоксидный наливной пол</td>
                    <td>2,2</td>
                    <td>0</td>
                    <td>1&nbsp;056</td>
                    <td>0</td>
                </tr>
                <tr>
                    <td>Эпоксидный грунт</td>
                    <td>0,");
            WriteLiteral(@"3</td>
                    <td>0</td>
                    <td>198</td>
                    <td>0</td>
                </tr>
                <tr>
                    <td>Тиксoтропная шпатлевка</td>
                    <td>0,5</td>
                    <td>0</td>
                    <td>240</td>
                    <td>0</td>
                </tr>
            </tbody>
        </table>
    </div>
    <ul class=""result-table"">
        <li>
            <p>Наименование</p>
            <p class=""val"">Промышленный, эпоксидный наливной пол</p>
            <p>Реком-й расход на 1 м2 (кг)</p>
            <p class=""val"">2,2</p>
            <p>Необх-е кол-во (кг)</p>
            <p class=""val"">0</p>
            <p>Цена на 1 м2 (руб.)</p>
            <p class=""val"">1&nbsp;056</p>
            <p>Всего</p>
            <p class=""val"">0</p>
        </li>
        <li>
            <p>Наименование</p>
            <p class=""val"">Эпоксидный грунт</p>
            <p>Реком-й расход на 1 м2 (кг)</p>
     ");
            WriteLiteral(@"       <p class=""val"">0,3</p>
            <p>Необх-е кол-во (кг)</p>
            <p class=""val"">0</p>
            <p>Цена на 1 м2 (руб.)</p>
            <p class=""val"">198</p>
            <p>Всего</p>
            <p class=""val"">0</p>
        </li>
        <li>
            <p>Наименование</p>
            <p class=""val"">Тиксoтропная шпатлевка</p>
            <p>Реком-й расход на 1 м2 (кг)</p>
            <p class=""val"">0,5</p>
            <p>Необх-е кол-во (кг)</p>
            <p class=""val"">0</p>
            <p>Цена на 1 м2 (руб.)</p>
            <p class=""val"">240</p>
            <p>Всего</p>
            <p class=""val"">0</p>
        </li>
    </ul>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
