#pragma checksum "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b3f2555256f32164aa6002862642ce52d2b2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DimProduct_Index), @"mvc.1.0.view", @"/Views/DimProduct/Index.cshtml")]
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
#line 1 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\_ViewImports.cshtml"
using WareHouseProject.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0b3f2555256f32164aa6002862642ce52d2b2d1", @"/Views/DimProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4112f622d07d99eedf41ddcaabfbaacfe8404c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DimProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DimProduct>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\" col-3\">\r\n        <ul>\r\n            <li> <a alt=\"0\" href=\"/DimProduct/ProductCategories/0\">All</a></li>\r\n");
#nullable restore
#line 72 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
             foreach (DimProductCategory item in ViewBag.ProductCategories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li> <a");
            BeginWriteAttribute("href", " href=\"", 2659, "\"", 2720, 2);
            WriteAttributeValue("", 2666, "/DimProduct/ProductCategories/", 2666, 30, true);
#nullable restore
#line 74 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
WriteAttributeValue("", 2696, item.ProductCategoryKey, 2696, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
                                                                                 Write(item.ProductCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 75 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 81 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
             foreach (DimProduct item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <div class=\"box\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3020, "\"", 3071, 2);
            WriteAttributeValue("", 3027, "/DimProduct/detail/", 3027, 19, true);
#nullable restore
#line 85 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
WriteAttributeValue("", 3046, item.ProductAlternateKey, 3046, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 3095, "\"", 3163, 2);
            WriteAttributeValue("", 3101, "data:image/jpeg;base64,", 3101, 23, true);
#nullable restore
#line 85 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
WriteAttributeValue("", 3124, Convert.ToBase64String(item.ImageFile), 3124, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3164, "\"", 3195, 1);
#nullable restore
#line 85 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
WriteAttributeValue("", 3170, item.ProductAlternateKey, 3170, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3231, "\"", 3282, 2);
            WriteAttributeValue("", 3238, "/DimProduct/detail/", 3238, 19, true);
#nullable restore
#line 86 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
WriteAttributeValue("", 3257, item.ProductAlternateKey, 3257, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"text-center\">\r\n                                <b> ");
#nullable restore
#line 88 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
                               Write(item.ProductAlternateKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </div>\r\n                        </a>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 95 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimProduct\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DimProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591