#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eae0dcfd693bb8ee44095900b30c3b4f29701892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Create), @"mvc.1.0.view", @"/Views/Flavors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eae0dcfd693bb8ee44095900b30c3b4f29701892", @"/Views/Flavors/Create.cshtml")]
    public class Views_Flavors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>New Treat</h1>\n<hr>\n");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label for=\"Name\">Name:</label>\n");
#nullable restore
#line 13 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new Flavor\" />\n");
#nullable restore
#line 15 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Flavors/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
