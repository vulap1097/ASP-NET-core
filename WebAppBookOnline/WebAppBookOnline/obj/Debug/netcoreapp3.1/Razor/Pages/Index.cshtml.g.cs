#pragma checksum "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a992f255cce27dd2d4b5dc0c7d1e7fb5c05191e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppBookOnline.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebAppBookOnline.Pages
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
#line 1 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\_ViewImports.cshtml"
using WebAppBookOnline;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a992f255cce27dd2d4b5dc0c7d1e7fb5c05191e7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c35a8b07676c75b23be054a02b737cebd2532c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <p class=""h3 p-3"">Welcome to TuHocICT's library!</p>
    <div>
        <table class=""table table-bordered table-sm"">
            <thead class=""thead-light"">
                <tr>
                    <th>Tiêu đề</th>
                    <th>Tác giả</th>
                    <th>Nhà xuất bản</th>
                    <th>Năm xuất bản</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                 foreach (var b in Model.books)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 670, "\"", 688, 2);
            WriteAttributeValue("", 677, "/book/", 677, 6, true);
#nullable restore
#line 24 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
WriteAttributeValue("", 683, b.Id, 683, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                                             Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 25 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                       Write(b.Authors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                       Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                       Write(b.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 931, "\"", 949, 2);
            WriteAttributeValue("", 938, "/book/", 938, 6, true);
#nullable restore
#line 29 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
WriteAttributeValue("", 944, b.Id, 944, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                            <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1057, 3);
            WriteAttributeValue("", 1031, "/book/", 1031, 6, true);
#nullable restore
#line 30 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
WriteAttributeValue("", 1037, b.Id, 1037, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1042, "?handler=delete", 1042, 15, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td colspan=\"5\"><strong>Tổng số sách trong thư viện: ");
#nullable restore
#line 34 "D:\VuquangLAp\ASP .NET-core\WebAppBookOnline\WebAppBookOnline\Pages\Index.cshtml"
                                                                    Write(Model.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td></tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
