#pragma checksum "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "954253c165a4d118d47edf310e475d7c57358369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VetServices_All), @"mvc.1.0.view", @"/Areas/Admin/Views/VetServices/All.cshtml")]
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
#line 1 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Models.Pets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Models.Employees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Models.VetServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Models.Clinics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Services.Pet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Services.Employee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Services.VetService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Services.Clinic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Data.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\_ViewImports.cshtml"
using PetCare.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"954253c165a4d118d47edf310e475d7c57358369", @"/Areas/Admin/Views/VetServices/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e1d095656573df73bb7cad07413d1a55c22761", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_VetServices_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AllVetServiceServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "VetServices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
  
    ViewBag.Title = "All Services";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3>OUR LATEST SERVICES</h3>\r\n\r\n    <hr class=\"my-4\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "954253c165a4d118d47edf310e475d7c573583697924", async() => {
                WriteLiteral("Add new Service");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <hr class=\"my-4\">\r\n</div>\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 19 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {
            var vetService = Model[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 554, "\"", 611, 2);
            WriteAttributeValue("", 562, "carousel-item", 562, 13, true);
#nullable restore
#line 22 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
WriteAttributeValue(" ", 575, i == 0 ? "active" : string.Empty, 576, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 657, "\"", 681, 1);
#nullable restore
#line 23 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
WriteAttributeValue("", 663, vetService.ImgUrl, 663, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 682, "\"", 711, 1);
#nullable restore
#line 23 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
WriteAttributeValue("", 688, vetService.ServiceName, 688, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""carousel-caption d-none d-md-block"">
                    <p style=""color: #000000"">
                        We offer a variety of pets services that are just right for your pet
                    </p>
                    <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "954253c165a4d118d47edf310e475d7c5735836911540", async() => {
#nullable restore
#line 28 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
                                                                                                                                        Write(vetService.ServiceName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vetServiceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
                                                                                                                 WriteLiteral(vetService.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vetServiceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vetServiceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vetServiceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 31 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<hr class=""my-4"">

<h4 class=""text-center"">SERVICE WE OFFER</h4>

<hr class=""my-3"">

<div class=""row"">
");
#nullable restore
#line 50 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
     foreach (var vetService in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-center col-md-6 col-xl-4\">\r\n\r\n            <div class=\"card-header-custom\">\r\n                ");
#nullable restore
#line 55 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
           Write(vetService.ServiceName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2083, "\"", 2107, 1);
#nullable restore
#line 58 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
WriteAttributeValue("", 2089, vetService.ImgUrl, 2089, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n\r\n            <p class=\"card-text-custom\" id=\"truncateLongTexts\">");
#nullable restore
#line 61 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
                                                          Write(vetService.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "954253c165a4d118d47edf310e475d7c5735836916796", async() => {
                WriteLiteral("LEARN MORE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vetServiceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
                                                                             WriteLiteral(vetService.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vetServiceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vetServiceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vetServiceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 64 "D:\Code C#\PetCare\PetCare-master\PetCare\Areas\Admin\Views\VetServices\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AllVetServiceServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591