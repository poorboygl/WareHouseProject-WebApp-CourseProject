#pragma checksum "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c79fc7e516b922620cbc5e6ba77aa6d3295ba8e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DimGeography_Index), @"mvc.1.0.view", @"/Views/DimGeography/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79fc7e516b922620cbc5e6ba77aa6d3295ba8e2", @"/Views/DimGeography/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4112f622d07d99eedf41ddcaabfbaacfe8404c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DimGeography_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DimGeography>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <th>Geography Key</th>
            <th>City</th>
            <th>State Province Code</th>
            <th>State Province Name</th>
            <th>Country Region Code</th>
            <th>Country Region Name</th>
            <th>Postal Code</th>
            <th>Ipaddress Locator</th>
        </tr>
    </thead>
");
#nullable restore
#line 15 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
     foreach (DimGeography item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.GeographyKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.StateProvinceCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.StateProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.CountryRegionCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.CountryRegionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
           Write(item.IpAddressLocator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\DimGeography\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DimGeography>> Html { get; private set; }
    }
}
#pragma warning restore 1591