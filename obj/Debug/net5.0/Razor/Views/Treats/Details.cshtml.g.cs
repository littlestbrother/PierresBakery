#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f6bc0a0ea33c8d7e4e9a522b04dcd55e273edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Details), @"mvc.1.0.view", @"/Views/Treats/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f6bc0a0ea33c8d7e4e9a522b04dcd55e273edc", @"/Views/Treats/Details.cshtml")]
    public class Views_Treats_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bakery.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Treat Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This Treat does not belong to any Flavors</p>\n");
#nullable restore
#line 14 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Flavors the Treat belongs to:</h4>\n  <ul>\n");
#nullable restore
#line 19 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
   Write(join.Flavor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
     using (Html.BeginForm("DeleteFlavor", "Treats"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
 Write(Html.Hidden("joinId", @join.FlavorTreatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
#nullable restore
#line 26 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 29 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 31 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Add a Flavor", "AddFlavor", new { id = Model.TreatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>");
#nullable restore
#line 33 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 34 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Edit Treat", "Edit", new { id = Model.TreatId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 35 "/home/aaron/Documents/epicodus/epicodus-fullstack/code-review/C#/PierresBakery/Views/Treats/Details.cshtml"
Write(Html.ActionLink("Delete Treat", "Delete", new { id = Model.TreatId }));

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
