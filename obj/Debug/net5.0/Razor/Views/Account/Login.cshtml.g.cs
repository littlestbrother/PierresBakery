#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e104653c67deb0301521f48fad54a4e173699968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 5 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
using Bakery.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e104653c67deb0301521f48fad54a4e173699968", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Log in with your account</h2>\n<hr />\n");
#nullable restore
#line 11 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"Email\">Email:</label>\n");
#nullable restore
#line 14 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"Pasword\">Password:</label>\n");
#nullable restore
#line 17 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\n");
#nullable restore
#line 20 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Account/Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
