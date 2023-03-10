#pragma checksum "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df48cc2a85d99e99105c2a437688963c725e71e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Archive), @"mvc.1.0.view", @"/Views/Product/Archive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df48cc2a85d99e99105c2a437688963c725e71e3", @"/Views/Product/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""col-md-12"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""overview-wrap"">
                            <h2 class=""title-1"">Silinmi?? ??r??nler</h2>
                        </div>
                    </div>
                </div>
            </div>
            <br />
");
#nullable restore
#line 15 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
             if (Model.Products.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-12"">
                    <div class=""table-responsive table--no-card m-b-40"">
                        <table class=""table table-borderless table-striped table-earning"">
                            <thead>
                                <tr>
                                    <th class=""text-center"">SAP Kod</th>
                                    <th class=""text-center"">Marka</th>
                                    <th class=""text-center"">Malzeme Tan??m??</th>
                                    <th class=""text-center"">Stok</th>
                                    <th class=""text-center"">Fiyat</th>
                                    <th class=""text-center"">Konum</th>
");
#nullable restore
#line 28 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                     if (User.IsInRole("Admin") || User.IsInRole("User"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th class=\"text-center\">Ara??lar</th>\r\n");
#nullable restore
#line 31 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                 foreach (var item in Model.Products)
                                {
                                    string color = "#FFFFFF";
                                    string textColor = "";

                                    if (((item.Stock - item.CriticalStock) <= 0))
                                    {
                                        color = "#FF4018";
                                        textColor = "#FFFFFF";
                                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr");
            BeginWriteAttribute("style", " style=\"", 2214, "\"", 2247, 3);
            WriteAttributeValue("", 2222, "background-color:", 2222, 17, true);
#nullable restore
#line 46 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue(" ", 2239, color, 2240, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2246, ";", 2246, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2316, "\"", 2340, 2);
            WriteAttributeValue("", 2324, "color:", 2324, 6, true);
#nullable restore
#line 48 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2330, textColor, 2330, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2422, "\"", 2446, 2);
            WriteAttributeValue("", 2430, "color:", 2430, 6, true);
#nullable restore
#line 49 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2436, textColor, 2436, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2534, "\"", 2558, 2);
            WriteAttributeValue("", 2542, "color:", 2542, 6, true);
#nullable restore
#line 50 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2548, textColor, 2548, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2640, "\"", 2664, 2);
            WriteAttributeValue("", 2648, "color:", 2648, 6, true);
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2654, textColor, 2654, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                                      if (item.Unit != null) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                                                          Write(item.Unit.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                                                                              ; }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2792, "\"", 2816, 2);
            WriteAttributeValue("", 2800, "color:", 2800, 6, true);
#nullable restore
#line 52 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2806, textColor, 2806, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                                Write(item.Currency.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 2919, "\"", 2943, 2);
            WriteAttributeValue("", 2927, "color:", 2927, 6, true);
#nullable restore
#line 53 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 2933, textColor, 2933, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                    Write(item.SubShelf.Shelf.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 53 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                                                                                              Write(item.SubShelf.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                         if (User.IsInRole("Admin"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-center\">\r\n                                                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3255, "\"", 3286, 3);
            WriteAttributeValue("", 3265, "editProduct(", 3265, 12, true);
#nullable restore
#line 57 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 3277, item.Id, 3277, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3285, ")", 3285, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"??r??n?? Geri Y??kle\">\r\n                                                    <i class=\"zmdi zmdi-refresh-sync\" style=\"color:White\"></i>\r\n                                                </a>\r\n                                            </td>\r\n");
#nullable restore
#line 61 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                         if (User.IsInRole("User"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-center\">\r\n                                                <a class=\"btn-block btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3837, "\"", 3868, 3);
            WriteAttributeValue("", 3847, "addToBasket(", 3847, 12, true);
#nullable restore
#line 65 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
WriteAttributeValue("", 3859, item.Id, 3859, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3867, ")", 3867, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <i class=\"zmdi zmdi-shopping-cart-add\" style=\"color:White\"></i>\r\n                                                </a>\r\n                                            </td>\r\n");
#nullable restore
#line 69 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tr>\r\n");
#nullable restore
#line 72 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <center><i>Bu kategoride ??r??n bulunamad??!</i></center>\r\n");
#nullable restore
#line 81 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Product\Archive.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<script>
    function editProduct(productId) {
        $.ajax({
            method: 'POST',
            url: '/Product/RemoveDelete/?id=' + productId,
            success: function (data) {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: '??r??n ba??ar??yla geri y??klenmi??tir!',
                    showConfirmButton: false,
                    timer: 800
                }).then(() => {
                    location.reload();
                })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
