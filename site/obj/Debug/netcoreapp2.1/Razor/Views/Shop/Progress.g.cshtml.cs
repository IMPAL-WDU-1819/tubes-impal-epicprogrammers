#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7716775242c7004b9db30cf27a682756aa89e71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Progress), @"mvc.1.0.view", @"/Views/Shop/Progress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Progress.cshtml", typeof(AspNetCore.Views_Shop_Progress))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7716775242c7004b9db30cf27a682756aa89e71f", @"/Views/Shop/Progress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Progress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 47, true);
            WriteLiteral("<div class=\"row site-employee-detail\">\n    <h1>");
            EndContext();
            BeginContext(73, 15, false);
#line 3 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
   Write(Model.Job.Jobid);

#line default
#line hidden
            EndContext();
            BeginContext(88, 14, true);
            WriteLiteral("</h1>\n    <h3>");
            EndContext();
            BeginContext(103, 33, false);
#line 4 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
   Write(Model.JobItem.Item2sell.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(136, 60, true);
            WriteLiteral("</h3>\n    <p>\n        <ul>\n            <li>Last updated at: ");
            EndContext();
            BeginContext(197, 21, false);
#line 7 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
                            Write(Model.Job.Lastupdated);

#line default
#line hidden
            EndContext();
            BeginContext(218, 30, true);
            WriteLiteral("</li>\n        </ul>\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 248, "\"", 287, 2);
            WriteAttributeValue("", 255, "emailto:", 255, 8, true);
#line 9 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
WriteAttributeValue("", 263, Model.Job.Employeeemail, 263, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(288, 116, true);
            WriteLiteral(">Contact Developers</a>\n        <h3>Last progress news from developers: </h3>\n        <hr/>\n        <p>\n            ");
            EndContext();
            BeginContext(405, 18, false);
#line 13 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
       Write(Model.Job.Progress);

#line default
#line hidden
            EndContext();
            BeginContext(423, 109, true);
            WriteLiteral("\n        </p>\n    </p>\n    <button onclick=\"window.history.back()\">\n        Go back\n    </button>\n    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 532, "\"", 602, 3);
            WriteAttributeValue("", 542, "window.location.href=\'/Shop/Pick/", 542, 33, true);
#line 19 "/home/sigismund/ProjectImpal/site/Views/Shop/Progress.cshtml"
WriteAttributeValue("", 575, Model.JobItem.Item2sellno, 575, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 601, "\'", 601, 1, true);
            EndWriteAttribute();
            BeginContext(603, 50, true);
            WriteLiteral(">\n        Go to Car show room\n    </button>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
