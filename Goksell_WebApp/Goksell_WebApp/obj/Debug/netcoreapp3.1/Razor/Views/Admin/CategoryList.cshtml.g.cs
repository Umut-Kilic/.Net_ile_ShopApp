#pragma checksum "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892dfc4749e7d47073271d10ff7e64bb842f2a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892dfc4749e7d47073271d10ff7e64bb842f2a3b", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69b853040cde0d65a240ff8d9cb310ea26b70e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoryDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"h3\">Admin Categories</h1>\r\n        <hr />\r\n\r\n        <a href=\"/admin/categories/create\" class=\"btn btn-primary\">Add Category</a>\r\n");
#nullable restore
#line 9 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
         if (Model.Count < 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                Ürün Bulunamamıştır.\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-1\">\r\n\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n            <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 23 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
                 foreach (var item in Model)
                {




#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <thead>
                        <tr>
                            <th style=""width:30px"">Id</th>
                            <th >Name</th>
                            
                            <th style=""width:250px;""></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>");
#nullable restore
#line 38 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
                           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 39 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                           
                            <td>
                                <div class=""row"">

                                    <div class=""col-md-6"">
                                            <a class=""btn btn-success w-100""");
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1401, 2);
            WriteAttributeValue("", 1367, "/admin/categories/", 1367, 18, true);
#nullable restore
#line 45 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1385, item.CategoryId, 1385, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                                      \r\n\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892dfc4749e7d47073271d10ff7e64bb842f2a3b8252", async() => {
                WriteLiteral("\r\n                                            <button class=\"btn btn-danger w-100\">Delete</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
                                                                                                   WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 59 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"




                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div> \r\n        <div class=\"col-md-1\">\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Admin\CategoryList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591