#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf7ebe8d8ec4ebbf8d1f6afecb07006edcf5105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_BuyList), @"mvc.1.0.view", @"/Views/Shop/BuyList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/BuyList.cshtml", typeof(AspNetCore.Views_Shop_BuyList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf7ebe8d8ec4ebbf8d1f6afecb07006edcf5105", @"/Views/Shop/BuyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_BuyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Item>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 344, true);
            WriteLiteral(@"<div>
    <table>
        <tr>
            <th>
                Id
            </th>
            <th>
                Nama
            </th>
            <th>
                Harga
            </th>
            <th>
                Status
            </th>
            <th>
                Remove
            </th>
        </tr>
        <tbody>
");
            EndContext();
#line 22 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
 foreach (var row in Model)
{

#line default
#line hidden
            BeginContext(392, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(430, 10, false);
#line 25 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
               Write(row.Itemno);

#line default
#line hidden
            EndContext();
            BeginContext(440, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(467, 23, false);
#line 26 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
               Write(row.Item2sell.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(490, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(517, 19, false);
#line 27 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
               Write(row.Item2sell.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(536, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(563, 15, false);
#line 28 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
               Write(row.Description);

#line default
#line hidden
            EndContext();
            BeginContext(578, 27, true);
            WriteLiteral("</td>\n                <td>\n");
            EndContext();
#line 30 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
                     if(row.Description==Globals.STR_ORDER_PLACED)
                    {

#line default
#line hidden
            BeginContext(694, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 725, "\"", 786, 3);
            WriteAttributeValue("", 735, "window.location.href=\'/Shop/RemoveList/", 735, 39, true);
#line 32 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
WriteAttributeValue("", 774, row.Itemno, 774, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 785, "\'", 785, 1, true);
            EndWriteAttribute();
            BeginContext(787, 73, true);
            WriteLiteral(">\n                        Cancel Order\n                        </button>\n");
            EndContext();
#line 35 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(929, 115, true);
            WriteLiteral("                        <button disabled=\"disabled\">You can\'t cancel this!</button>\n                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1044, "\"", 1103, 3);
            WriteAttributeValue("", 1054, "window.location.href=\'/Shop/Progress/", 1054, 37, true);
#line 39 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
WriteAttributeValue("", 1091, row.Itemno, 1091, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1102, "\'", 1102, 1, true);
            EndWriteAttribute();
            BeginContext(1104, 31, true);
            WriteLiteral(">Show progress detail</button>\n");
            EndContext();
#line 40 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
                    }

#line default
#line hidden
            BeginContext(1157, 40, true);
            WriteLiteral("                </td>\n            </tr>\n");
            EndContext();
#line 43 "/home/sigismund/ProjectImpal/site/Views/Shop/BuyList.cshtml"
}

#line default
#line hidden
            BeginContext(1199, 34, true);
            WriteLiteral("        </tbody>\n    </table>\n    ");
            EndContext();
            BeginContext(1233, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e569f98e317f46a1be6b00fd9319d30b", async() => {
                BeginContext(1239, 58, true);
                WriteLiteral("\n        <button>\n        Clear\n        </button>    \n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1304, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
