#pragma checksum "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df25b23902ae5b9791e44ddace09dd8a51d895a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.BasketDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderBasketDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProductDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.SubCategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CategoryDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.BrandDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.CurrencyDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.OrderBasketLogDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using EntityLayer.Dtos.ProductLogDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\_ViewImports.cshtml"
using WarehouseTracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df25b23902ae5b9791e44ddace09dd8a51d895a", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""col-md-12"">
                <div class=""row"">
                    <div class=""col-md-12"">

                    </div>
                </div>
            </div>
            <br />
");
#nullable restore
#line 14 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
             if (Model.Orders.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-12"">
                    <div class=""table-responsive table--no-card m-b-40"">
                        <table class=""table table-borderless table-striped table-earning"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">Sipariş Veren</th>
                                    <th class=""text-center"">Açıklama</th>
                                    <th class=""text-center"">Tarih</th>
");
#nullable restore
#line 24 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                     if (User.IsInRole("Admin") || User.IsInRole("User"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th class=\"text-center\">Araçlar</th>\r\n");
#nullable restore
#line 27 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                 foreach (var item in Model.Orders)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 34 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                                           Write(item.AppUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                                                                   Write(item.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 35 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                                           Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
#nullable restore
#line 36 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                                           Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                         if (User.IsInRole("Admin") || User.IsInRole("User"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"text-center\">\r\n");
#nullable restore
#line 40 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                         if (User.IsInRole("Admin"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2101, "\"", 2134, 3);
            WriteAttributeValue("", 2111, "completeOrder(", 2111, 14, true);
#nullable restore
#line 42 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
WriteAttributeValue("", 2125, item.Id, 2125, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2133, ")", 2133, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Onay\">\r\n                                                <i class=\"zmdi zmdi-check\" style=\"color:White\"></i>\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2356, "\"", 2387, 3);
            WriteAttributeValue("", 2366, "cancelOrder(", 2366, 12, true);
#nullable restore
#line 45 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
WriteAttributeValue("", 2378, item.Id, 2378, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2386, ")", 2386, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" title=\"Sipariş İptal\">\r\n                                                <i class=\"zmdi zmdi-close\" style=\"color:White\"></i>\r\n                                            </a>\r\n");
#nullable restore
#line 48 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                         if (item.OrderBaskets.Count > 0 || item.OrderBasketLogs.Count > 0) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2812, "\"", 2844, 3);
            WriteAttributeValue("", 2822, "orderDetails(", 2822, 13, true);
#nullable restore
#line 50 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
WriteAttributeValue("", 2835, item.Id, 2835, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2843, ")", 2843, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Sipariş Detayı\">\r\n                                                <i class=\"zmdi zmdi-storage\" style=\"color:White\"></i>\r\n                                            </a>\r\n");
#nullable restore
#line 53 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Sipariş İptal!</p>\r\n");
#nullable restore
#line 57 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n");
#nullable restore
#line 59 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 66 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <center><i>Sipariş bulunamadı.</i></center>\r\n");
#nullable restore
#line 70 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div id=""orderDetailsModalPage""></div>
<script>

    function completeOrder(orderId) {
        Swal.fire({
            title: 'Siparişi onaylamak istediğinize emin misiniz?',
            text: ""İşlem geri alınamaz!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#d33',
            cancelButtonColor: '#3085d6',
            cancelButtonText: 'Vazgeç',
            confirmButtonText: 'Evet, onayla!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: ""POST"",
                    url: ""/Order/Delete/"" + orderId,
                    success: function (result) {
                        Swal.fire({
                            position: 'center',
                            icon: 'success',
                            title: 'Başarıyla onaylanmıştır!',
                            showConfirmButton: false,
                            timer: 8");
            WriteLiteral(@"00
                        }).then(() => {
                            location.reload();
                        })

                    },
                    error: function (data) {
                    }
                });
            }
        })

    }
    // ====================================
    function cancelOrder(orderId) {
        Swal.fire({
            title: 'Siparişi iptal istediğinize emin misiniz?',
            text: ""İşlem geri alınamaz!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#d33',
            cancelButtonColor: '#3085d6',
            cancelButtonText: 'Vazgeç',
            confirmButtonText: 'Evet, iptal et!'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: ""POST"",
                    url: ""/Order/Cancel/"" + orderId,
                    success: function (result) {
                        Swal.fire({
                          ");
            WriteLiteral(@"  position: 'center',
                            icon: 'success',
                            title: 'Başarıyla iptal edilmiştir!',
                            showConfirmButton: false,
                            timer: 800
                        }).then(() => {
                            location.reload();
                        })

                    },
                    error: function (data) {
                    }
                });
            }
        })

    }
    function orderDetails(orderId) {
        $.ajax({
            url: '/Order/Details/?Id=' + orderId,
            success: function (data) {
                $('#orderDetailsModalPage').html(data);
                $('#orderDetailsModal').modal('show');
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
