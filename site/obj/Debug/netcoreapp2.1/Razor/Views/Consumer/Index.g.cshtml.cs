#pragma checksum "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea6fcfb4a22a252edf8d655040c7ba68d7c69fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consumer_Index), @"mvc.1.0.view", @"/Views/Consumer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consumer/Index.cshtml", typeof(AspNetCore.Views_Consumer_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6fcfb4a22a252edf8d655040c7ba68d7c69fee", @"/Views/Consumer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consumer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Consumer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
 using (Html.BeginForm("SignUp", "Login" , FormMethod.Post)) { 
    

#line default
#line hidden
            BeginContext(86, 28, false);
#line 4 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
#line 4 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
                                 ;

     

#line default
#line hidden
            BeginContext(123, 106, false);
#line 6 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Email ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(236, 109, false);
#line 7 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Username ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(352, 105, false);
#line 8 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Pass ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(464, 106, false);
#line 9 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Notel ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(577, 108, false);
#line 10 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Address ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(692, 105, false);
#line 11 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"
Write(Html.TextBoxFor(m => m.Nama ,new {@class = "form-control",@placeholder="EnterName",@requried="required"}));

#line default
#line hidden
            EndContext();
            BeginContext(798, 52, true);
            WriteLiteral("    <input type=\"submit\" value=\"Enter the value\" />\n");
            EndContext();
#line 13 "/home/sigismund/ProjectImpal/site/Views/Consumer/Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Consumer> Html { get; private set; }
    }
}
#pragma warning restore 1591
