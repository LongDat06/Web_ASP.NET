#pragma checksum "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c115477c68bde4e9cece28caf4330f6e905fad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chitietdonhang_chitiethoadon), @"mvc.1.0.view", @"/Views/Chitietdonhang/chitiethoadon.cshtml")]
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
#line 1 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\_ViewImports.cshtml"
using DERSIX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
using DERSIX.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c115477c68bde4e9cece28caf4330f6e905fad", @"/Views/Chitietdonhang/chitiethoadon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dcf9784cd9acd8bae88adeef53dd442a2757fa6", @"/Views/_ViewImports.cshtml")]
    public class Views_Chitietdonhang_chitiethoadon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
  
    var sum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79c115477c68bde4e9cece28caf4330f6e905fad4326", async() => {
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
<link href=""https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600;700&display=swap""
      rel=""stylesheet"">


<div class=""to"">

    <div class=""row"">

        <!-- Area Chart -->
        <div class=""col-xl-8 col-lg-7"">


            <!-- Card Body -->
            <div class=""card-body"">
                <h1>Chi ti???t ????n ?????t h??ng</h1>
                <table>
                    <tr>
                        <th>M?? Chi ti???t ho?? ????n</th>
                        <th>M?? s???n ph???m</th>
                        <th>S??? l?????ng</th>
                        <th>Gi??</th>
                        <th>Th??nh ti???n</th>

                    </tr>
                    <tr>
");
#nullable restore
#line 38 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                         foreach (var item in (List<Chitiethoadon>)Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 41 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                              
                                var t = @item.Soluong * @item.Gia;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td style=\"center\">");
#nullable restore
#line 45 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                          Write(item.Idchitiethoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:left\">");
#nullable restore
#line 46 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                                   Write(item.Idsp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td style=\"text-align:right\">");
#nullable restore
#line 47 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                                    Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td style=\"text-align:left\"> ");
#nullable restore
#line 48 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                                    Write(item.Gia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td style=\"text-align:right\">");
#nullable restore
#line 49 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                                    Write(t);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                        sum += @t;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td colspan=6>\r\n\r\n                            T???ng ti???n = ");
#nullable restore
#line 57 "C:\Users\ThanhDat\source\repos\DERSIX\DERSIX\Views\Chitietdonhang\chitiethoadon.cshtml"
                                   Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\r\n\r\n                        </td>\r\n\r\n                        </tr>\r\n\r\n\r\n                    </table>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n");
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
