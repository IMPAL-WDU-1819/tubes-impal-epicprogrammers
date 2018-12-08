#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f61e8baaf1cb338268053cc5ea4895187b3523a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f61e8baaf1cb338268053cc5ea4895187b3523a", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Job>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 101, true);
            WriteLiteral("\n<div class=\"row site-employee-detail\">\n    <div class=\"col-md-3\">\n        <h1>Your Latest Task</h1>\n");
            EndContext();
#line 6 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
     if(Model.Count==0)
    {

#line default
#line hidden
            BeginContext(148, 35, true);
            WriteLiteral("        <h3>There is no task!</h3>\n");
            EndContext();
#line 9 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(204, 24, true);
            WriteLiteral("        <h3>Latest Job: ");
            EndContext();
            BeginContext(229, 30, false);
#line 12 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
                   Write(Model.ElementAt(0).Lastupdated);

#line default
#line hidden
            EndContext();
            BeginContext(259, 67, true);
            WriteLiteral("</h3>\n        <p>\n            <ul>\n                <li>Working on: ");
            EndContext();
            BeginContext(327, 43, false);
#line 15 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
                           Write(Model.ElementAt(0).Item.Item2sell.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(370, 36, true);
            WriteLiteral("</li>\n                <li>Consumer: ");
            EndContext();
            BeginContext(407, 29, false);
#line 16 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
                         Write(Model.ElementAt(0).Item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(436, 37, true);
            WriteLiteral("</li>\n            </ul>\n        </p>\n");
            EndContext();
#line 19 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(479, 404, true);
            WriteLiteral(@"    </div>
    <div class=""col-md-9"">
        <h1>Last 5 task</h1>
        <table>
            <tr>
                <th>
                    Job Id
                </th>
                <th>
                    Product
                </th>
                <th>
                    Lastupdated
                </th>
                <th>
                    Detail
                </th>
            </tr>
");
            EndContext();
#line 38 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
            BeginContext(943, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(981, 10, false);
#line 42 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
               Write(item.Jobid);

#line default
#line hidden
            EndContext();
            BeginContext(991, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1018, 29, false);
#line 43 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
               Write(item.Item.Item2sell.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1074, 16, false);
#line 44 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
               Write(item.Lastupdated);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 28, true);
            WriteLiteral("</td>\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1118, "\"", 1160, 2);
            WriteAttributeValue("", 1125, "/Employee/DetailedOrder/", 1125, 24, true);
#line 45 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
WriteAttributeValue("", 1149, item.Jobid, 1149, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1161, 39, true);
            WriteLiteral(">See detail</a></td>\n            </tr>\n");
            EndContext();
#line 47 "/home/sigismund/ProjectImpal/site/Views/Employee/Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1223, 145, true);
            WriteLiteral("        </table>\n        <button onclick=\"window.location.href=\'/Employee/Order\'\">\n            Show all order\n        </button>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591