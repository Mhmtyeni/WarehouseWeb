#pragma checksum "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b05be01e7cb03ee8d3bb3f0bc1c47ac0e4bcf9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Settings), @"mvc.1.0.view", @"/Views/Account/Settings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b05be01e7cb03ee8d3bb3f0bc1c47ac0e4bcf9c", @"/Views/Account/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"601f36cd9ad5165e6dd8805994e0a985bdccf611", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/male.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""main-content"">
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">

            <div class=""card"">
                <div class=""card-header"">
                    <center><strong class=""card-title"">Hesap Ayarları</strong></center>
                </div>
                <div class=""card-body"">
                    <center>
");
#nullable restore
#line 12 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
                         if (ViewData.ModelState[""] != null && ViewData.ModelState[""].Errors.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""alert alert-danger"" role=""alert"">
                                <button type=""button"" class=""close"" data-dismiss=""alert"">×</button>
                                <style>
                                    .help-block ul {
                                        list-style-type: none;
                                    }
                                </style>
                                <span class=""help-block"">
                                    ");
#nullable restore
#line 22 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
                               Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n");
#nullable restore
#line 25 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </center>
                    <div class=""row"">
                        <div class="" col-md-6"">
                            <br />
                            <br />
                            <br />
                            <br />
                            <div class=""row"">
                                <div class="" col-md-12"">
                                    <center>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b05be01e7cb03ee8d3bb3f0bc1c47ac0e4bcf9c10345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </center>
                                </div>
                            </div>
                            <br />
                            <div class=""row"">
                                <div class="" col-md-12"">
                                    <center>
                                        <a onclick=""changePassword()"" class=""btn btn-success"">
                                            <i class=""zmdi zmdi-lock"" style=""color:white;font-size:17px;""></i><i style=""color:white; font-size:20px;"">&nbsp; Şifre Değiştir</i>
                                        </a>
                                    </center>
                                </div>
                            </div>
                            <br />
");
#nullable restore
#line 51 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
                             if(User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class="" col-md-12"">
                                    <center>

                                        <a onclick=""resetPassword()"" class=""btn btn-warning"">
                                            <i class=""zmdi zmdi-lock"" style=""color:white;font-size:17px;""></i><i style=""color:white; font-size:20px;"">&nbsp; Personel Şifre Sıfırla</i>
                                        </a>
                                    </center>
                                </div>
                            </div>
");
#nullable restore
#line 63 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\" col-md-6\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b05be01e7cb03ee8d3bb3f0bc1c47ac0e4bcf9c13606", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <label>Sicil</label>\r\n                                    <input class=\"au-input au-input--full\" type=\"text\" name=\"UserName\" placeholder=\"Sicil\" required");
                BeginWriteAttribute("value", " value=\"", 3637, "\"", 3660, 1);
#nullable restore
#line 69 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
WriteAttributeValue("", 3645, Model.UserName, 3645, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Ad</label>
                                    <input class=""au-input au-input--full"" type=""text"" name=""FirstName"" placeholder=""Ad"" required");
                BeginWriteAttribute("value", " value=\"", 3946, "\"", 3970, 1);
#nullable restore
#line 73 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
WriteAttributeValue("", 3954, Model.FirstName, 3954, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Soyad</label>
                                    <input class=""au-input au-input--full"" type=""text"" name=""LastName"" placeholder=""Soyad"" required");
                BeginWriteAttribute("value", " value=\"", 4261, "\"", 4284, 1);
#nullable restore
#line 77 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
WriteAttributeValue("", 4269, Model.LastName, 4269, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>Kart Numarası</label>
                                    <input class=""au-input au-input--full"" type=""number"" name=""CardId"" placeholder=""Kart Numarası"" required");
                BeginWriteAttribute("value", " value=\"", 4591, "\"", 4612, 1);
#nullable restore
#line 81 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
WriteAttributeValue("", 4599, Model.CardId, 4599, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label>E-mail Adresi</label>
                                    <input class=""au-input au-input--full"" type=""email"" name=""Email"" placeholder=""Email"" required");
                BeginWriteAttribute("value", " value=\"", 4909, "\"", 4929, 1);
#nullable restore
#line 85 "C:\Users\tugayo\Documents\GitHub\WarehouseWeb\WarehouseTracking\Views\Account\Settings.cshtml"
WriteAttributeValue("", 4917, Model.Email, 4917, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <br />
                                <button id=""add"" class=""au-btn au-btn--block au-btn--blue m-b-20"" onclick=""validate()"" type=""submit"">Kaydet</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    function validate() {

        if (document.forms['form_id'].reportValidity()) {
            event.preventDefault();
            var form = document.getElementById(""form_id"");
            Swal.fire({
                title: 'Kaydetmek istediğinize emin misiniz?',
                text: ""Sicil değiştirildiğinde yeniden giriş yapmanız gerekmektedir."",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#70da00',
                cancelButtonColor: '#3085d6',
                cancelButtonText: 'Vazgeç',
                confirmButtonText: 'Evet, kaydet!'
            }).then((result) => {
                if (result.isConfirmed) {
                    form.submit();
                }
            })
        }

    }
    //===================================================
    function ");
            WriteLiteral(@"changePassword() {
        Swal.fire({
            title: 'Şifre Değiştirme',
            html:
                '<input type=""password"" id=""swal-input1"" class=""swal2-input"" placeholder=""Eski Şifre"" autocomplete=""off"">' +
                '<input type=""password"" id=""swal-input2"" class=""swal2-input"" placeholder=""Yeni Şifre"" autocomplete=""off"">',
            showCancelButton: true,
            cancelButtonText: 'Vazgeç', 
            confirmButtonText: 'Onayla',
            showLoaderOnConfirm: true,
            preConfirm: (login) => {
                var OldPassword = $('#swal-input1').val();
                var NewPassword = $('#swal-input2').val();
                if (OldPassword != '' && NewPassword != '' && OldPassword.length >= 8 && NewPassword.length >= 8) {

                }
                else {
                    Swal.showValidationMessage(
                        `Şifre alanı boş bırakılamaz! Şifre en az 8 karakterden oluşmalıdır!`
                    )
                }
      ");
            WriteLiteral(@"      },
            allowOutsideClick: () => !Swal.isLoading()
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/Account/ChangePassword',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'OldPassword': $('#swal-input1').val(),
                        'NewPassword': $('#swal-input2').val(),
                    },
                    success: function (data) {
                        if (data == true) {
                            Swal.fire({
                                position: 'center',
                                icon: 'success',
                                title: 'Başarıyla değiştirilmiştir!',
                                showConfirmButton: false,
                                timer: 800
                            }).then(() => {
                            })
                        }
                        else {
     ");
            WriteLiteral(@"                       Swal.fire({
                                position: 'center',
                                icon: 'error',
                                title: 'Eski şifrenizi eksik veya hatalı girdiniz!',
                                showConfirmButton: false,
                                timer: 1500
                            }).then(() => {
                            })
                        }
                    },
                    error: function (data) {
                    }
                });
            }
        })
    }
    //==============================================0
    function resetPassword() {
        var name = '';
        Swal.fire({
            title: 'Personel sicilini giriniz!',
            input: 'text',
            inputAttributes: {
                autocapitalize: 'off'
            },
            showCancelButton: true,
            cancelButtonText: 'Vazgeç',
            confirmButtonText: 'Sıfırla',
            showLoaderOnCon");
            WriteLiteral(@"firm: true,
            preConfirm: (login) => {
                if (login != '') {
                    name = login;
                }
                else {
                    Swal.showValidationMessage(
                        `Sicil alanı boş bırakılamaz!`
                    )
                }
            },
            allowOutsideClick: () => !Swal.isLoading()
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    url: '/Account/ResetPassword',
                    type: 'POST',
                    dataType: 'json',
                    data: {
                        'UserName': name,
                    },
                    success: function (data) {
                        if (data == true) {
                            Swal.fire({
                                position: 'center',
                                icon: 'success',
                                title: 'Başarıyla sıfırlanmıştır!',
                ");
            WriteLiteral(@"                showConfirmButton: false,
                                timer: 800
                            }).then(() => {
                            })
                        }                        
                        else {
                            Swal.fire({
                                position: 'center',
                                icon: 'error',
                                title: 'Sicili eksik veya hatalı girdiniz!',
                                showConfirmButton: false,
                                timer: 1500
                            }).then(() => {
                            })
                        }
                    },
                    error: function (data) {
                    }
                });
            }
        })

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
