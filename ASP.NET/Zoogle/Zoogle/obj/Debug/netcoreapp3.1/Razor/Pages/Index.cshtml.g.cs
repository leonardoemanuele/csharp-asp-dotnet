#pragma checksum "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bda9d07a52171763a8fa3e155145fc50f8ea8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zoogle.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Zoogle.Pages
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
#line 1 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/_ViewImports.cshtml"
using Zoogle;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bda9d07a52171763a8fa3e155145fc50f8ea8f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d798fabb5b0c68a0b6b3891a7d9a013b77efff1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 id=\"zoogle-title\">Zoogle</h1>\n    <p>Where animals always feel lucky</p>\n</div>\n\n<div class=\"accordion\" id=\"accordion\">\n");
#nullable restore
#line 13 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
     for (int i = 0; i < Model.Animals.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\n            <div class=\"card-header pl-1\"");
            BeginWriteAttribute("id", " id=", 346, "", 367, 1);
#nullable restore
#line 16 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
WriteAttributeValue("", 350, $"heading-{i}", 350, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <h2 class=\"mb-0\">\n                    <button class=\"btn btn-link font-weight-bold collapsed animal-header\" type=\"button\" data-toggle=\"collapse\" data-target=");
#nullable restore
#line 18 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                                                                                                                       Write($"#collapse-{i}");

#line default
#line hidden
#nullable disable
            WriteLiteral(" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=", 582, "", 615, 1);
#nullable restore
#line 18 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
WriteAttributeValue("", 597, $"collapse-{i}", 597, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <img class=\"animal-icon mr-2\"");
            BeginWriteAttribute("src", " src=", 670, "", 701, 1);
#nullable restore
#line 19 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
WriteAttributeValue("", 675, Model.Animals[i].ImageUrl, 675, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 19 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                                                                  Write(Model.Animals[i].CommonName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <!--
                            <img class=""plus-icon icon-visible"" src=""https://content.codecademy.com/courses/asp-dot-net/animal-icons/plus-blue-32-32.png"" />
                            <img class=""minus-icon icon-hidden"" src=""https://content.codecademy.com/courses/asp-dot-net/animal-icons/minus-blue-32-32.png"" />
                                -->
                    </button>
                </h2>
            </div>

            <div");
            BeginWriteAttribute("id", " id=", 1201, "", 1223, 1);
#nullable restore
#line 28 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
WriteAttributeValue("", 1205, $"collapse-{i}", 1205, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=", 1240, "", 1274, 1);
#nullable restore
#line 28 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
WriteAttributeValue("", 1257, $"heading-{i}", 1257, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">Scientific Name</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 31 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                    Write(Model.Animals[i].Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h5 class=\"card-title\">Description</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 33 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                    Write(Model.Animals[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h5 class=\"card-title\">Habitat</h5>\n                    <ul>\n");
#nullable restore
#line 36 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                         foreach (string habitat in Model.Animals[i].Habitats)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 38 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                           Write(habitat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 39 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                    <h5 class=\"card-title\">Size</h5>\n                    <p class=\"card-text\">Height: ");
#nullable restore
#line 42 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                            Write(Model.Animals[i].Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm<br />Weight: ");
#nullable restore
#line 42 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
                                                                                     Write(Model.Animals[i].Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</p>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 46 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
