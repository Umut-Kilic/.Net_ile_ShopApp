#pragma checksum "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a60a4462d8ccc51487fbcd185e0606ea58c6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a60a4462d8ccc51487fbcd185e0606ea58c6ea", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69b853040cde0d65a240ff8d9cb310ea26b70e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
  
    var products = Model.Products;
    //var categories = Model.Categories;
    //var IsThingPopular = Model.Products.Count > 2 ? "popular" : "nonpopular";

#line default
#line hidden
#nullable disable
            DefineSection("Categories", async() => {
                WriteLiteral(" \r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
 if (Model.Products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
                                          

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 31 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\aracl\Masaüstü\Dersler\C#\Goksell_WebApp\Goksell_WebApp\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
