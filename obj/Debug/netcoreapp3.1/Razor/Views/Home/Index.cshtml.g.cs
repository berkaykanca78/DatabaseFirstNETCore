#pragma checksum "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dae88a11aa712b7dec62d604e0af81a9dc2cac33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\_ViewImports.cshtml"
using DatabaseFirstCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\_ViewImports.cshtml"
using DatabaseFirstCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae88a11aa712b7dec62d604e0af81a9dc2cac33", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead99ff1457ac7005e8600611fcecee7cc64b249", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ListeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 8 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 11 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Soyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Yasi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Maas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SozlesmeSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.MevkiAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UlkeAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TakimAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 33 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Adi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Soyadi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Yasi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Maas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SozlesmeSuresi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MevkiAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UlkeAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TakimAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "D:\Dosyalar\Projeler\ASP.NET\DatabaseFirstCore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ListeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
