#pragma checksum "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5949d9f1605649c91c187caac4d35bfb976bb14c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryEdit), @"mvc.1.0.view", @"/Views/Admin/CategoryEdit.cshtml")]
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
#nullable restore
#line 2 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using Goksell_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using Goksell_WebApp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\_ViewImports.cshtml"
using Goksell_WebApp.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5949d9f1605649c91c187caac4d35bfb976bb14c", @"/Views/Admin/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69b853040cde0d65a240ff8d9cb310ea26b70e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("admin/categoryEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoryDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"row\">\r\n        <h1 class=\"h3\">Edit Category</h1>\r\n        <hr />\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c7331", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c7605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 7 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c9261", async() => {
                    WriteLiteral("Name");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 9 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5949d9f1605649c91c187caac4d35bfb976bb14c10822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 10 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                                          WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c13149", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 11 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c14905", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 14 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5949d9f1605649c91c187caac4d35bfb976bb14c16429", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 15 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                                         WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c18754", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 16 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-8"">
            <div class=""row"">
                <div class=""col-md-12"">
             
                    <table class=""table table-bordered table-sm"">
                        
                        <thead>
                            <tr>
                                <th style=""width:30px;"">Id</th>
                                <th style=""width:100px;"">Image</th>
                                <th>Name</th>
                                <th style=""width:30px;"">Price</th>
                                <th style=""width:30px;"">Onaylı</th>
                                <th style=""width:200px;"">Onaylı</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 39 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                             if (Model.Products.Count > 0)
                            {
                                
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                     for (int i = 0; i < Model.Products.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div id=\"products\">\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2027, "\"", 2056, 3);
            WriteAttributeValue("", 2034, "Products[", 2034, 9, true);
#nullable restore
#line 45 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2043, i, 2043, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2045, "].ProdcutId", 2045, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2057, "\"", 2093, 3);
            WriteAttributeValue("", 2065, "Model.Products[", 2065, 15, true);
#nullable restore
#line 45 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2080, i, 2080, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2082, "].ProdcutId", 2082, 11, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2163, "\"", 2191, 3);
            WriteAttributeValue("", 2170, "Products[", 2170, 9, true);
#nullable restore
#line 46 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2179, i, 2179, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2181, "].ImageUrl", 2181, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2192, "\"", 2227, 3);
            WriteAttributeValue("", 2200, "Model.Products[", 2200, 15, true);
#nullable restore
#line 46 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2215, i, 2215, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2217, "].ImageUrl", 2217, 10, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2297, "\"", 2321, 3);
            WriteAttributeValue("", 2304, "Products[", 2304, 9, true);
#nullable restore
#line 47 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2313, i, 2313, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2315, "].Name", 2315, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2322, "\"", 2353, 3);
            WriteAttributeValue("", 2330, "Model.Products[", 2330, 15, true);
#nullable restore
#line 47 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2345, i, 2345, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2347, "].Name", 2347, 6, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2423, "\"", 2448, 3);
            WriteAttributeValue("", 2430, "Products[", 2430, 9, true);
#nullable restore
#line 48 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2439, i, 2439, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2441, "].Price", 2441, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2449, "\"", 2481, 3);
            WriteAttributeValue("", 2457, "Model.Products[", 2457, 15, true);
#nullable restore
#line 48 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2472, i, 2472, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2474, "].Price", 2474, 7, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2551, "\"", 2581, 3);
            WriteAttributeValue("", 2558, "Products[", 2558, 9, true);
#nullable restore
#line 49 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2567, i, 2567, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2569, "].IsApproved", 2569, 12, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2582, "\"", 2619, 3);
            WriteAttributeValue("", 2590, "Model.Products[", 2590, 15, true);
#nullable restore
#line 49 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 2605, i, 2605, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2607, "].IsApproved", 2607, 12, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 52 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                 foreach (var item in Model.Products)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                       Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5949d9f1605649c91c187caac4d35bfb976bb14c29650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3018, "~/img/", 3018, 6, true);
#nullable restore
#line 59 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 3024, item.ImageUrl, 3024, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n");
#nullable restore
#line 64 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                             if (item.IsApproved)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 67 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 71 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3902, "\"", 3940, 2);
            WriteAttributeValue("", 3909, "/admin/products/", 3909, 16, true);
#nullable restore
#line 74 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 3925, item.ProductId, 3925, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">content</a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5949d9f1605649c91c187caac4d35bfb976bb14c33766", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4190, "\"", 4213, 1);
#nullable restore
#line 76 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4198, item.ProductId, 4198, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                                                                                       WriteLiteral(Model.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryEdit.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                       \r\n                    </table>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591