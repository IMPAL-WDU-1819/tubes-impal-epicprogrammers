#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9764aaa834daa79fcb35ffb2845893ab9c43650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_DetailedOrder), @"mvc.1.0.view", @"/Views/Employee/DetailedOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/DetailedOrder.cshtml", typeof(AspNetCore.Views_Employee_DetailedOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9764aaa834daa79fcb35ffb2845893ab9c43650", @"/Views/Employee/DetailedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_DetailedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 47, true);
            WriteLiteral("<div class=\"row site-employee-detail\">\n    <h1>");
            EndContext();
            BeginContext(73, 15, false);
#line 3 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
   Write(Model.Job.Jobid);

#line default
#line hidden
            EndContext();
            BeginContext(88, 14, true);
            WriteLiteral("</h1>\n    <h3>");
            EndContext();
            BeginContext(103, 34, false);
#line 4 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
   Write(Model.Job.Item.Item2sell.Namamobil);

#line default
#line hidden
            EndContext();
            BeginContext(137, 55, true);
            WriteLiteral("</h3>\n    <p>\n        <ul>\n            <li>Ordered at: ");
            EndContext();
            BeginContext(193, 21, false);
#line 7 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                       Write(Model.Job.Lastupdated);

#line default
#line hidden
            EndContext();
            BeginContext(214, 35, true);
            WriteLiteral("</li>\n            <li>Assigned to: ");
            EndContext();
            BeginContext(250, 23, false);
#line 8 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                        Write(Model.Job.Employeeemail);

#line default
#line hidden
            EndContext();
            BeginContext(273, 291, true);
            WriteLiteral(@"</li>
        </ul>
        <div>
            <h4>Required part</h4>
            <table>
                <tr>
                    <th>Part No</th>
                    <th>Part Name</th>
                    <th>Price in IDR</th>
                    <th>Availibilty</th>
                </tr>
");
            EndContext();
#line 19 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                 foreach (var item in Model.Parts)
                {

#line default
#line hidden
            BeginContext(633, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(687, 16, false);
#line 22 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                       Write(item.Part.Itemno);

#line default
#line hidden
            EndContext();
            BeginContext(703, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(738, 18, false);
#line 23 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                       Write(item.Part.Namapart);

#line default
#line hidden
            EndContext();
            BeginContext(756, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(791, 15, false);
#line 24 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                       Write(item.Part.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(806, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(841, 13, false);
#line 25 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                       Write(item.Part.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(854, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 27 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(904, 68, true);
            WriteLiteral("            </table>\n        </div>\n        <div>\n            <div>\n");
            EndContext();
#line 32 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
 using (Html.BeginForm("ProgressUpdate", "Employee" , FormMethod.Post, new { @onsubmit="return OnSubmitForm(event)" })) {                 

#line default
#line hidden
            BeginContext(1111, 64, true);
            WriteLiteral("                <h4>Progress Update</h4>\n                <hr />\n");
            EndContext();
            BeginContext(1192, 65, false);
#line 35 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 35 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                                                                                  ;

#line default
#line hidden
            BeginContext(1259, 61, true);
            WriteLiteral("                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1320, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421b9b66a4f74a969859b0eb3e1af163", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 37 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Job.Progress);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1358, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1379, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e1afebea6b2d4aee8e9271b38ee8c227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 38 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Job.Jobid);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 38 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                                                        WriteLiteral(Model.Job.Jobid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1447, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1468, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a6e4c848c7b4f2c80385157fc117595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 39 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Job.Progress);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1533, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1554, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4307a8d9d6ff446b8836fe80457c8a37", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 40 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Job.Progress);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1621, 176, true);
            WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <button id=\"\" type=\"submit\" class=\"btn btn-default\">Submit</button>\n                </div>\n");
            EndContext();
#line 45 "/home/sigismund/ProjectImpal/site/Views/Employee/DetailedOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(1815, 50, true);
            WriteLiteral("            </div>\n        </div>\n    </p>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobPartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591