#pragma checksum "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebb473fb318c02b94dd07ee76f99133a580eed0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LTCSDL.Web.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace LTCSDL.Web.Pages
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
#line 1 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\_ViewImports.cshtml"
using LTCSDL.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebb473fb318c02b94dd07ee76f99133a580eed0f", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205aacb6dcca1d0f56a30fc97a3841c93384744b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Xử lý dữ liệu với bảng [Categories]";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>Thông tin Category có mã bằng [2] như sau</p>
<table style=""width:325px;"">
    <tr>
        <th width=""20%"">Cate ID</th>
        <th width=""40%"">Category Name</th>
        <th width=""40%"">Description</th>
    </tr>
    <tr>
        <td>");
#nullable restore
#line 16 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml"
       Write(Model.cate.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml"
       Write(Model.cate.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "D:\Lập trình CSDL (Thầy Hiếu)\LTCSDL-Demo\LTCSDL-IT81-3Tiers\LTCSDL.Web\Pages\Privacy.cshtml"
       Write(Model.cate.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
