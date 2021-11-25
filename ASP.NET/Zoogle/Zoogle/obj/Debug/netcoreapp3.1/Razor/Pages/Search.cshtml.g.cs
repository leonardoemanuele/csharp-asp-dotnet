#pragma checksum "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec71d52c688e493d0621e76ef6cd8413043415d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zoogle.Pages.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec71d52c688e493d0621e76ef6cd8413043415d", @"/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d798fabb5b0c68a0b6b3891a7d9a013b77efff1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-text-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter an animal\'s common name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Animal common name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("button-addon2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-bar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\n    <h1 id=\"zoogle-title\">Zoogle</h1>\n    <p>Where animals always feel lucky</p>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec71d52c688e493d0621e76ef6cd8413043415d6016", async() => {
                WriteLiteral(@"
        <div class=""input-group-prepend bg-transparent"">
            <span id=""search-icon"" class=""input-group-text bg-transparent"" aria-hidden=""true"">
                <img class=""magnify-icon"" src=""https://content.codecademy.com/courses/asp-dot-net/animal-icons/magnify-blue-64-64.png"" />
            </span>
        </div>

        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ec71d52c688e493d0621e76ef6cd8413043415d6616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n        <div class=\"input-group-append\">\n            <input id=\"search-button-input\" class=\"btn btn-outline-secondary\" type=\"submit\" id=\"button-addon2\" value=\"Search\">\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n<div class=\"card\">\n");
#nullable restore
#line 28 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
     if (Model.FoundAnimal == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"no-results\" class=\"card-header\">No results found</div>\n");
#nullable restore
#line 31 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-header pl-1\">\n            <h2 class=\"mb-0\">\n                <button class=\"btn btn-link font-weight-bold animal-header\" type=\"button\">\n                    <img class=\"animal-icon mr-2\"");
            BeginWriteAttribute("src", " src=", 1314, "", 1346, 1);
#nullable restore
#line 37 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
WriteAttributeValue("", 1319, Model.FoundAnimal.ImageUrl, 1319, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 37 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                                                                               Write(Model.FoundAnimal.CommonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </button>\n            </h2>\n        </div>\n");
            WriteLiteral("        <div>\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">Scientific Name</h5>\n                <p class=\"card-text\">");
#nullable restore
#line 45 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                                Write(Model.FoundAnimal.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <h5 class=\"card-title\">Description</h5>\n                <p class=\"card-text\">");
#nullable restore
#line 47 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                                Write(Model.FoundAnimal.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <h5 class=\"card-title\">Habitat</h5>\n                <ul>\n");
#nullable restore
#line 50 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                     foreach (string habitat in Model.FoundAnimal.Habitats)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 52 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                       Write(habitat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 53 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n                <h5 class=\"card-title\">Size</h5>\n                <p class=\"card-text\">Height: ");
#nullable restore
#line 56 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                                        Write(Model.FoundAnimal.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm<br />Weight: ");
#nullable restore
#line 56 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
                                                                                  Write(Model.FoundAnimal.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg</p>\n            </div>\n        </div>\n");
#nullable restore
#line 59 "/Users/leonardoemanuele/Programming/ASP.NET/Zoogle/Zoogle/Pages/Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zoogle.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zoogle.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zoogle.Pages.SearchModel>)PageContext?.ViewData;
        public Zoogle.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591