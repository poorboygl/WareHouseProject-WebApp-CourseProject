#pragma checksum "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2034542f68d8aceea03bf2fdf3cb93c4e25111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2034542f68d8aceea03bf2fdf3cb93c4e25111", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4112f622d07d99eedf41ddcaabfbaacfe8404c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cart>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\" col-2\">\r\n\r\n        </div>\r\n        <div class=\" col-8\">\r\n            <div><b>Day Created: </b>");
#nullable restore
#line 10 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                                Write(Model[0].CreatedDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>CodeUser: </b>");
#nullable restore
#line 11 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                             Write(Model[0].CodeUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>FullName :</b>");
#nullable restore
#line 12 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                              Write($"{Model[0].Firstname} {Model[0].MiddleName} {Model[0].LastName}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("            <div><b>Phone: </b>");
#nullable restore
#line 14 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                          Write(Model[0].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div><b>Address: </b>");
#nullable restore
#line 15 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                            Write(Model[0].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            <table class=""table table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>ProductAlternateKey</th>
                        <th>Product SubcategoryName</th>
                        <th>Product Name</th>
                        <th>Quantity</th>
                        <th>costs (per product)</th>
                        <th>Total Price</th>
                        <th>Change Quantity</th>
                        <th>Delete</th>
                    </tr>
                </thead>
");
#nullable restore
#line 29 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                   decimal total = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                 foreach (Cart item in Model)
                {
                    total += item.Quantity * item.Price.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 34 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
               Write(item.ProductAlternateKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
               Write(item.ProductSubcategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                <td>");
#nullable restore
#line 40 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
               Write(item.Price.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                Write(item.Price.Value*item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <input type=\"number\"");
            BeginWriteAttribute("v", " v=\"", 1684, "\"", 1704, 1);
#nullable restore
#line 43 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1688, item.ProductKey, 1688, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"qty\"");
            BeginWriteAttribute("value", " value=\"", 1716, "\"", 1738, 1);
#nullable restore
#line 43 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1724, item.Quantity, 1724, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\" max=\"100\" />\r\n                </td>\r\n                <td>\r\n                    <a class=\"d\"");
            BeginWriteAttribute("href", " href=\"", 1839, "\"", 1875, 2);
            WriteAttributeValue("", 1846, "/cart/delete/", 1846, 13, true);
#nullable restore
#line 46 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1859, item.ProductKey, 1859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"5\"><b>Total Price</b></td>\r\n                        <td><b>");
#nullable restore
#line 53 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
                          Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></td>
                    </tr>
                </tfoot>
            </table>
        </div>
        <div class="" col-2"">
        </div>
    </div>
    <script>
        $('.d').click(function () {
            return confirm(""Are You sure delete?"");
        });
        $('input[name=""qty""]').click(function () {
            // console.log($(this).attr('v'));
            var obj = { ProductKey: $(this).attr('v'), quantity: $(this).val() };
            $.post('/cart/edit', obj, function (ret) {

                //console.log(ret);
                window.location.reload();
            });
        });
    </script>
");
#nullable restore
#line 75 "D:\DoAnWeb\DoAnWeb-NguyenQuocVu-0988816494\WareHouseProject\WareHouseProject.WebApp\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
