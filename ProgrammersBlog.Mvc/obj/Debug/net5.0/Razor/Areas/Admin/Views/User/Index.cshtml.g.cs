#pragma checksum "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e3ad737f54b53f25134065ec90bb0c7d1177a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e3ad737f54b53f25134065ec90bb0c7d1177a8", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.UserListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-image-table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/userIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kullanıcılar Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""modalPlaceHolder"" aria-hidden=""true""></div>
    <div class=""card mb-4 mt-2"">
                            <div class=""card-header"">
                                <i class=""fas fa-table mr-1""></i>
                                Kullanıcılar
                            </div>
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display: none;"">
                <span class=""sr-only"">Yükleniyor...</span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""usersTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                    <tr>
                        <th>ID</th>
                        <th>Kullanıcı Adı</th>
                        <th>E-Posta Adresi</th>
                        <th>Telefon Numarası</th>
                        <th>Resim</th>
                        <th>İşlemler</th>
                    </tr>
                    </thead>
             ");
            WriteLiteral(@"       <tfoot>
                    <tr>
                        <th>ID</th>
                        <th>Kullanıcı Adı</th>
                        <th>E-Posta Adresi</th>
                        <th>Telefon Numarası</th>
                        <th>Resim</th>
                        <th>İşlemler</th>
                    </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 42 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                     foreach (var user in Model.Users)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("name", " name=\"", 1766, "\"", 1781, 1);
#nullable restore
#line 44 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1773, user.Id, 1773, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                           Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0e3ad737f54b53f25134065ec90bb0c7d1177a89952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2033, "~/img/", 2033, 6, true);
#nullable restore
#line 49 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2039, user.Picture, 2039, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2059, user.UserName, 2059, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button class=\"btn btn-primary btn-sm btn-update\" data-id=\"");
#nullable restore
#line 51 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                      Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-edit\"></span></button>\r\n                                <button class=\"btn btn-danger btn-sm btn-delete\" data-id=\"");
#nullable restore
#line 52 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                                                                                     Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span></button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n     </div>\r\n");
#nullable restore
#line 61 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 65 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n        Dashboard sayfasına geri dönmek için lütfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e3ad737f54b53f25134065ec90bb0c7d1177a814579", async() => {
                WriteLiteral("tıklayınız.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\Galip Can Karaarslan\Downloads\ProgrammersBlog-Proje-Dosyasi-D103\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e3ad737f54b53f25134065ec90bb0c7d1177a816572", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.UserListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
