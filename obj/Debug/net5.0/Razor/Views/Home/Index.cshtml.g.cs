#pragma checksum "C:\Users\DianaDaniels\OneDrive - Inner City Stars Foundation\Desktop\nsc47\DdPortal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b226b233192a6bfd73a8ec4be0cf9cfd024415"
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
#line 1 "C:\Users\DianaDaniels\OneDrive - Inner City Stars Foundation\Desktop\nsc47\DdPortal\Views\_ViewImports.cshtml"
using DdPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DianaDaniels\OneDrive - Inner City Stars Foundation\Desktop\nsc47\DdPortal\Views\_ViewImports.cshtml"
using DdPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b226b233192a6bfd73a8ec4be0cf9cfd024415", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed618fdd6c15a221bd754c885597a14781cdba9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <Name>");
#nullable restore
#line 2 "C:\Users\DianaDaniels\OneDrive - Inner City Stars Foundation\Desktop\nsc47\DdPortal\Views\Home\Index.cshtml"
     Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("-Home Page</Name> \r\n");
            WriteLiteral(@"
<div class=""container text-center"" style=""margin-top:30px"">
    <h2 class=""display-4"">Welcome Back!</h2>
</div>

<div class=""container col-sm-4"" style=""margin-top:30px"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column position-static"">
                <div class= ""text-center"">
                    <dt><strong>Home Office</strong></dt>
                    <dd>
                        <br>
                    </dd>
                </div>
                <div class= ""text-center"">  
                    <dt><strong>Status</strong></dt>
                    <dd>
                        <br>
                    </dd>
                    <small id=""Office ID"" class=""form-text text-muted"">Search for offices using the search tool above, or select one of the other options from the menu.</small>
                 </div>    
            </div>
        </div>
            <button type=""button"" class=""btn btn-primary btn-lg"" style= ""margin-top:30px"" >");
            WriteLiteral(" Details</button>\r\n    </div>\r\n   ");
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
