#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe1934989f4d20f76cc0e156b6ccc33d3d51a26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe1934989f4d20f76cc0e156b6ccc33d3d51a26", @"/Views/Treats/Edit.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this Treat: ");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label for=\"Description\">Description:</label>\n");
#nullable restore
#line 16 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label for=\"FlavorId\">Select Flavor:</label>\n");
#nullable restore
#line 19 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
Write(Html.DropDownList("FlavorId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 22 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
