#pragma checksum "D:\AXATHGI\Repos\Payment\Payment.UI\Views\QR\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b981cb54b1279e785123738b24bbff0532a40d1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QR_Index), @"mvc.1.0.view", @"/Views/QR/Index.cshtml")]
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
#line 1 "D:\AXATHGI\Repos\Payment\Payment.UI\Views\_ViewImports.cshtml"
using Payment.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AXATHGI\Repos\Payment\Payment.UI\Views\_ViewImports.cshtml"
using Payment.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b981cb54b1279e785123738b24bbff0532a40d1e", @"/Views/QR/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bd9d2328b3183e214391412d2c7eec8a26837c", @"/Views/_ViewImports.cshtml")]
    public class Views_QR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\AXATHGI\Repos\Payment\Payment.UI\Views\QR\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>QR Code</h1>\r\n    <img");
            BeginWriteAttribute("src", " src=\'", 75, "\'", 101, 1);
#nullable restore
#line 7 "D:\AXATHGI\Repos\Payment\Payment.UI\Views\QR\Index.cshtml"
WriteAttributeValue("", 81, Url.Action("image"), 81, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 102, "\"", 108, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <script>\r\n            $(document).ready(function () {\r\n                alert(\'ViewBag.image\');\r\n            });\r\n    </script>\r\n");
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
