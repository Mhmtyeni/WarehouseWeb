#pragma checksum "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "295e9371f2f243c69817cd51458cea0993f1f05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295e9371f2f243c69817cd51458cea0993f1f05f", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/basket.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "295e9371f2f243c69817cd51458cea0993f1f05f6254", async() => {
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
<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">
            <div class=""container py-5 h-100"">
                <div class=""row d-flex justify-content-center align-items-center h-100"">
                    <div class=""col-12"">
                        <div class=""card card-registration card-registration-2"" style=""border-radius: 15px;"">
                            <div class=""card-body p-0"">
                                <div class=""row g-0"">
                                    <div class=""col-lg-8"">
                                        <div class=""p-5"">
                                            <div class=""d-flex justify-content-between align-items-center mb-5"">
                                                <h1 class=""fw-bold mb-0 text-black"">Sepetim</h1>
                                                <h6 class=""mb-0 text-muted"">");
#nullable restore
#line 16 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                                       Write(Model.Baskets.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ürün</h6>\r\n                                            </div>\r\n                                            <hr class=\"my-4\">\r\n");
#nullable restore
#line 19 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                             foreach (var item in Model.Baskets)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""row mb-4 d-flex justify-content-between align-items-center"">
                                                    <div class=""col-md-2 col-lg-2 col-xl-2"">
                                                        <img src=""https://cdn-icons-png.flaticon.com/512/1547/1547183.png""
                                                             class=""img-fluid rounded-3""");
            BeginWriteAttribute("alt", " alt=\"", 1712, "\"", 1736, 1);
#nullable restore
#line 24 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1718, item.Product.Name, 1718, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    </div>\r\n                                                    <div class=\"col-md-3 col-lg-3 col-xl-3\">\r\n                                                        <h6 class=\"text-muted\">");
#nullable restore
#line 27 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                                          Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                        <h6 class=\"text-black mb-0\">");
#nullable restore
#line 28 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                                               Write(item.Product.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                    </div>
                                                    <div class=""col-md-3 col-lg-3 col-xl-2 d-flex"">
                                                        <button class=""btn btn-link px-2""
                                                                onclick=""this.parentNode.querySelector('input[type=number]').stepDown()"">
                                                            <i class=""fas fa-minus""></i>
                                                        </button>
");
#nullable restore
#line 35 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                           string id = "form" + item.ProductId.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <input");
            BeginWriteAttribute("id", " id=\"", 2832, "\"", 2840, 1);
#nullable restore
#line 36 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2837, id, 2837, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"1\"");
            BeginWriteAttribute("max", " max=\"", 2849, "\"", 2874, 1);
#nullable restore
#line 36 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2855, item.Product.Stock, 2855, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"quantity\"");
            BeginWriteAttribute("value", " value=\"", 2891, "\"", 2913, 1);
#nullable restore
#line 36 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2899, item.Quantity, 2899, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number""
                                                               onKeyDown=""return false"" class=""form-control form-control-sm"" style=""width:70px"" />

                                                        <button class=""btn btn-link px-2""
                                                                onclick=""this.parentNode.querySelector('input[type=number]').stepUp()"">
                                                            <i class=""fas fa-plus""></i>
                                                        </button>
                                                        <a class=""btn btn-primary zmdi zmdi-refresh-alt""");
            BeginWriteAttribute("onclick", " onclick=\"", 3568, "\"", 3608, 3);
            WriteAttributeValue("", 3578, "updateProduct(", 3578, 14, true);
#nullable restore
#line 43 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3592, item.ProductId, 3592, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3607, ")", 3607, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" style=""color:white""></a>
                                                    </div>
                                                    <div class=""col-md-3 col-lg-2 col-xl-2 offset-lg-1"">
                                                        <h6 class=""mb-0"">
                                                            Stok:  ");
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                              Write(item.Product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                                                        if (item.Product.Unit != null)
                                                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                        Write(item.Product.Unit.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                                                                    ;
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </h6>
                                                    </div>
                                                    <div class=""col-md-1 col-lg-1 col-xl-1 text-end"">
                                                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4427, "\"", 4484, 5);
            WriteAttributeValue("", 4437, "deleteProduct(", 4437, 14, true);
#nullable restore
#line 53 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue("", 4451, item.ProductId, 4451, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4466, ",", 4466, 1, true);
#nullable restore
#line 53 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
WriteAttributeValue(" ", 4467, item.AppUserId, 4468, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4483, ")", 4483, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-muted\"><i class=\"fas fa-times\"></i></a>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 56 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <hr class=""my-4"">

                                            <div class=""pt-5"">
                                                <h6 class=""mb-0"">
                                                    <a href=""#!"" class=""text-body"">
                                                        <i class=""fas fa-long-arrow-alt-left me-2""></i> Geri Dön
                                                    </a>
                                                </h6>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-lg-4 bg-grey"">
                                        <div class=""p-5"">
                                            <h3 class=""fw-bold mb-5 mt-2 pt-1"">Bilgiler</h3>
                                            <hr class=""my-4"">


                                            <h5 class=""text-uppercase mb-3"">Sipariş ");
            WriteLiteral(@"Açıklaması</h5>

                                            <div class=""mb-5"">
                                                <div class="" row"">
                                                    <div class=""col-md-4"">
                                                        <h5 class=""text-uppercase mb-3"" style=""margin-top:13px;"">Fabrika : </h5>
                                                    </div>
                                                    <div class=""col-md-8"">
                                                        <select name=""select"" id=""factory"" class=""form-control"" required>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="" row"">
                                                    <div class=""col-md-4"">
                                                        <h5 class=""text-uppercase");
            WriteLiteral(@" mb-3"" style=""margin-top:13px;"">Proje : </h5>
                                                    </div>
                                                    <div class=""col-md-8"">
                                                        <select name=""select"" id=""project"" class=""form-control"" required>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class=""form-outline"">
                                                    <input required type=""text"" id=""form3Examplea2"" class=""form-control form-control-lg"" />
                                                </div>
                                            </div>

                                            <hr class=""my-4"">
");
#nullable restore
#line 101 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                              
                                                int totalCount = 0;
                                                foreach (var item in Model.Baskets)
                                                {
                                                    totalCount += item.Quantity;
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"d-flex justify-content-between mb-5\">\r\n                                                <h5 class=\"text-uppercase\">Toplam Adet</h5>\r\n                                                <h5>");
#nullable restore
#line 110 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                                               Write(totalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Adt.</h5>
                                            </div>
                                            <button type=""button"" class=""btn btn-dark btn-block btn-lg""
                                                    data-mdb-ripple-color=""dark"" onclick=""addOrder()"">
                                                Sipariş Ver
                                            </button>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>

    $(document).ready(function () {
        getFactories();
        $('#factory').on(""change"", function () {
            getProjects();
        })
    });

    // ===========================
    function deleteProduct(productId, userId) {
        $.ajax({
            url: '/Basket/Delete?productId=' + ");
            WriteLiteral(@"productId + '&userId=' + userId,
            type: ""POST"",
            success: function () {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Başarıyla sepetten silinmiştir!',
                    showConfirmButton: false,
                    timer: 800
                }).then(() => {
                    location.reload();
                })
            }
        });
    }
    // ============================
    function updateProduct(productId) {
        var formId = ""#form"" + productId;
        $.ajax({
            url: '/Basket/Edit',
            type: ""POST"",
            data: {
                'Quantity': $(formId).val(),
                'ProductId': productId,
            },
            success: function () {
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Adet başarıyla güncellenmiştir!',
                  ");
            WriteLiteral(@"  showConfirmButton: false,
                    timer: 800
                }).then(() => {
                    location.reload();
                })
            }
        });
    }
    
    function addOrder() {  
        var factory = $(""#factory option:selected"").text().toUpperCase();
        var project = $(""#project option:selected"").text().toUpperCase();
        var item = factory + "" "" + "" "" + project + "" "" + document.getElementById(""form3Examplea2"").value;        
        var countBasket = ");
#nullable restore
#line 183 "C:\Users\mehmetyen\Desktop\WarehouseWeb - Mehmet Githup\WarehouseTracking\Views\Basket\Index.cshtml"
                     Write(Model.Baskets.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        if (countBasket > 0) {
                Swal.fire({
                    title: 'Sipariş onaylıyor musunuz?',
                    text: ""Sipariş ancak yetkili tarafından iptal edilebilir!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#d33',
                    cancelButtonColor: '#3085d6',
                    cancelButtonText: 'Vazgeç',
                    confirmButtonText: 'Evet, ver!'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            url: '/Order/Add',
                            type: ""POST"",
                            data: {
                                'Note': item,
                            },
                            success: function () {
                                $.ajax({
                                    url: '/Order/Receipt/',
                                    method: ""GET"",
  ");
            WriteLiteral(@"                                  contentType: ""application/json"",
                                    dataType: ""html"",
                                    success: function (data) {
                                        var printWindow = window.open('', '', 'height=1024,width=768');
                                        var divContents = data;
                                        printWindow.document.write(divContents);
                                        printWindow.document.close();
                                        printWindow.print();
                                        printWindow.close();
                                        window.location.reload();
                                    }
                                });
                            }
                        });
                    }
                })
            }
        else {
            Swal.fire({
                position: 'center',
                icon: 'error',
                tit");
            WriteLiteral(@"le: 'Sepette ürün yok!',
                showConfirmButton: false,
                timer: 800
            }).then(() => {
            })
        }
    }
    //===========================
    function getProjects() {
        $.ajax({
            type: ""GET"",
            url: ""/Project/GetByFactoryId?factoryId="" + $(""#factory"").val(),
            success: function (data) {
                $('#project').empty();
                for (var i = 0; i < data.projects.$values.length; i++) {
                    var select = document.getElementById(""project"");
                    select.appendChild(new Option(data.projects.$values[i].name, data.projects.$values[i].id));
                }
            }
        });
    }
    //==============================
    function getFactories() {
        $.ajax({
            type: ""GET"",
            url: ""/Factory/GetAll"",
            data: ""{}"",
            success: function (data) {
                var s = '';
                for (var i = 0; i < data.f");
            WriteLiteral(@"actories.$values.length; i++) {
                    s += '<option value=""' + data.factories.$values[i].id + '"">' + data.factories.$values[i].name + '</option>';
                }
                $(""#factory"").html(s);
                getProjects();
            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591