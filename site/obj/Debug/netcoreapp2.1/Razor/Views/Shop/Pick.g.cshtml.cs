#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e3a0d8db79d8cc7b59e9621849a69a01880553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Pick), @"mvc.1.0.view", @"/Views/Shop/Pick.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Pick.cshtml", typeof(AspNetCore.Views_Shop_Pick))]
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
#line 1 "/home/sigismund/ProjectImpal/site/Views/_ViewImports.cshtml"
using site;

#line default
#line hidden
#line 2 "/home/sigismund/ProjectImpal/site/Views/_ViewImports.cshtml"
using site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e3a0d8db79d8cc7b59e9621849a69a01880553", @"/Views/Shop/Pick.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Pick : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item2sell>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 70, true);
            WriteLiteral("\n<div class=\"row site-shop-detail\">\n    <div class=\"row\">\n        <h1>");
            EndContext();
            BeginContext(89, 15, false);
#line 5 "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml"
       Write(Model.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(104, 86, true);
            WriteLiteral("</h1>\n    </div>\n    <div class=\"row\">\n        <div class=\"md-col-4\">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 190, "\"", 209, 1);
#line 9 "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml"
WriteAttributeValue("", 196, Model.Imgurl, 196, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(210, 92, true);
            WriteLiteral(" class=\"img-responsive\"/>\n        </div>\n        <div class=\"md-col-8\">\n            <h3>Rp. ");
            EndContext();
            BeginContext(303, 11, false);
#line 12 "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml"
               Write(Model.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(314, 21, true);
            WriteLiteral("</h3>\n            <p>");
            EndContext();
            BeginContext(336, 17, false);
#line 13 "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(353, 24, true);
            WriteLiteral("</p>\n            <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 377, "\"", 438, 3);
            WriteAttributeValue("", 387, "window.location.href=\'/Shop/Buy/", 387, 32, true);
#line 14 "/home/sigismund/ProjectImpal/site/Views/Shop/Pick.cshtml"
WriteAttributeValue("", 419, Model.Item2sellno, 419, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 437, "\'", 437, 1, true);
            EndWriteAttribute();
            BeginContext(439, 46, true);
            WriteLiteral(">Buy</button>\n        </div>\n    </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item2sell> Html { get; private set; }
    }
}
#pragma warning restore 1591
