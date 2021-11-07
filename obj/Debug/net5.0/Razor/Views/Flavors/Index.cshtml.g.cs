#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d57f8ba206cd5b44e54b19c81b9f0d39bfc83a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Index), @"mvc.1.0.view", @"/Views/Flavors/Index.cshtml")]
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
#line 5 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
using Bakery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d57f8ba206cd5b44e54b19c81b9f0d39bfc83a", @"/Views/Flavors/Index.cshtml")]
    public class Views_Flavors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Flavors</h1>\n\n");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No Flavors have been added yet!</h3>\n");
#nullable restore
#line 12 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 15 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
   foreach(Flavor Flavor in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 17 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
   Write(Html.ActionLink($"{Flavor.Name}", "Details", new { id = Flavor.FlavorId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 21 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Add new Flavor", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 22 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
