#pragma checksum "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad325f02c41c16fd4f7c9e53b0e577d277e8745b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Receipt), @"mvc.1.0.view", @"/Views/Order/Receipt.cshtml")]
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
#line 1 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.BasketDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderBasketDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProductDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.SubCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.BrandDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CurrencyDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderBasketLogDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProductLogDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\_ViewImports.cshtml"
using WarehouseTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad325f02c41c16fd4f7c9e53b0e577d277e8745b", @"/Views/Order/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap-4.1/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad325f02c41c16fd4f7c9e53b0e577d277e8745b6620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style id=""table_style"" type=""text/css"">
    body {
        font-family: Arial;
        font-size: 10pt;
    }

    table {
        border: 1px;
        border-color: black;
        border-collapse: collapse;
    }

        table th {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }

        table th, table td {
            padding: 5px;
            border: 2px solid #000000;
        }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad325f02c41c16fd4f7c9e53b0e577d277e8745b8216", async() => {
                WriteLiteral(@"
    <div id=""dvContents"" style=""border: 3px solid black; padding: 5px,5px,5px,5px; width:420px"">
        <center><h3>BEYAZ EŞYA</h3></center>
        <center><h3>OPG Ambar</h3></center>
        <table cellspacing=""0"" rules=""all"" border=""1"" style=""width:416px"">
            <thead>
                <tr>
                    <th>Ad</th>
                    <th>Adt</th>
                    <th>Stok</th>
                    <th>Konum</th>
                </tr>
            </thead>

");
#nullable restore
#line 44 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
             foreach (var item in Model.OrderBaskets)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                    Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><center>");
#nullable restore
#line 48 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></td>\r\n                    <td><center>");
#nullable restore
#line 49 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                           Write(item.Product.Stock);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></td>\r\n                    <td><center>");
#nullable restore
#line 50 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                           Write(item.Product.SubShelf.Shelf.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 50 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                                                               Write(item.Product.SubShelf.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</center></td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n        <br />\r\n        <center><h6>Açıklaması: ");
#nullable restore
#line 56 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                           Write(Model.Note);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></center>\r\n        <center><h6 style=\"font-weight:bold\">");
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                                        Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                                                                  Write(Model.AppUser.FirstName.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 57 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
                                                                                                     Write(Model.AppUser.LastName.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></center>\r\n        <center><h6>");
#nullable restore
#line 58 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Order\Receipt.cshtml"
               Write(DateTime.Now);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></center>\r\n    </div>\r\n    <br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    function PrintTable() {
        var printWindow = window.open('', '', 'height=200,width=400');
        printWindow.document.write('<html><head><title>Table Contents</title>');

        //Print the Table CSS.
        var table_style = document.getElementById(""table_style"").innerHTML;
        printWindow.document.write('<style type = ""text/css"">');
        printWindow.document.write(table_style);
        printWindow.document.write('</style>');
        printWindow.document.write('</head>');

        //Print the DIV contents i.e. the HTML Table.
        printWindow.document.write('<body>');
        var divContents = document.getElementById(""dvContents"").innerHTML;
        printWindow.document.write(divContents);
        printWindow.document.write('</body>');

        printWindow.document.write('</html>');
        printWindow.document.close();
        printWindow.print();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591