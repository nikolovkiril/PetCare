#pragma checksum "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8017330f32c3ac2b67f745bd47d3ab80a7e72f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Details), @"mvc.1.0.view", @"/Views/Pets/Details.cshtml")]
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
#line 1 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Models.Pets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Models.Employees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Models.VetServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Models.Clinics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Services.Pet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Services.Employee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Services.VetService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Services.Clinic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Data.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8017330f32c3ac2b67f745bd47d3ab80a7e72f1", @"/Views/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e1d095656573df73bb7cad07413d1a55c22761", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetDetailsServiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card text-center responsive col-md-6 col-xl-4\" style=\"background-color: #a06f5a\" >\r\n    <div class=\"card-header font-weight-bold\" style=\"background-color: #dcdcdc\">\r\n       ");
#nullable restore
#line 8 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
  Write(Model.Animal.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n       Breed: ");
#nullable restore
#line 9 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
         Write(Model.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br />\r\n       Sex:  <kbd><code>");
#nullable restore
#line 10 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(Model.GenderType.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></kbd>\r\n    </div>\r\n    <div class=\"card-body text-white\">\r\n        <h5 class=\"card-title text-center\">");
#nullable restore
#line 13 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is ");
#nullable restore
#line 13 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                                                     Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Years old</h5>\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 565, "\"", 583, 1);
#nullable restore
#line 14 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
WriteAttributeValue("", 571, Model.Image, 571, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p class=\"card-text-custom\">");
#nullable restore
#line 15 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8017330f32c3ac2b67f745bd47d3ab80a7e72f19763", async() => {
                WriteLiteral("Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8017330f32c3ac2b67f745bd47d3ab80a7e72f111216", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-petId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["petId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-petId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["petId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8017330f32c3ac2b67f745bd47d3ab80a7e72f113679", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-petId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["petId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-petId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["petId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetDetailsServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
