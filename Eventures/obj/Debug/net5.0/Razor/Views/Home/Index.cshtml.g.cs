#pragma checksum "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7255e850520245bd5a733f4aa810afe6b51523e4"
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
#line 1 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\_ViewImports.cshtml"
using Eventures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\_ViewImports.cshtml"
using Eventures.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7255e850520245bd5a733f4aa810afe6b51523e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a955b74d506cfc9fe1d131dcd867512aad58ad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml"
 if (!this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron bg-eventures w-75 mx-auto"">
        <h1>Eventures: Events and Tickets</h1>
        <hr class=""hr-2 bg-dark"" />
        <h3 class=""mt-4""><a href=""/Identity/Account/Login"">Login</a> to start ""eventing"".</h3>
        <h3 class=""mt-4""><a href=""/Identity/Account/Register"">Register</a> if you don't have an account.</h3>
    </div>
");
#nullable restore
#line 13 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"jumbotron bg-eventures w-75 mx-auto\">\r\n        <h1 class=\"text-center\">Welcome, ");
#nullable restore
#line 17 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml"
                                    Write(this.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <hr class=""hr-2 bg-secondary"" />
        <h4 class=""mt-4 text-secondary text-center"">Eventures wishes you an exciting experience.</h4>
        <h3 class=""mt-4"">View <a href=""/Events/All"">all events</a>.</h3>
        <h3 class=""mt-4"">Create a <a href=""/Events/Create"">new event</a>.</h3>
    </div>
");
#nullable restore
#line 23 "C:\Users\Student\Documents\New folder (2)\Eventure\Eventures\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
