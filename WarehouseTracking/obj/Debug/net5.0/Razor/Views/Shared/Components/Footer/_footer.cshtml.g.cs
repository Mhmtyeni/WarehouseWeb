#pragma checksum "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Shared\Components\Footer\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5784adae5a4eb415de9bfa5f9c2f0231c44a4c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer__footer), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/_footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5784adae5a4eb415de9bfa5f9c2f0231c44a4c1", @"/Views/Shared/Components/Footer/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""loading""></div>

<script>
    $('#loading').hide();
    ////$('#loading').bind('ajaxStart', function () {

    ////}).bind('ajaxStop', function () {

    ////});
    $(document).on({
        ajaxStart: function () {
            $('#loading').show();
        },
        ajaxStop: function () {
            $('#loading').hide();
        }
    });
</script>
");
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
