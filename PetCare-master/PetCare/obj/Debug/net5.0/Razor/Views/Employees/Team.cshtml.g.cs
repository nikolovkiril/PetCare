#pragma checksum "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35960a8d27966438dfe27e2fa4e2f5fb10999a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Team), @"mvc.1.0.view", @"/Views/Employees/Team.cshtml")]
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
using PetCare.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Data.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\_ViewImports.cshtml"
using PetCare.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35960a8d27966438dfe27e2fa4e2f5fb10999a8d", @"/Views/Employees/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2caffe34d60a8f5dcf272c136946eca460983c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeDetailsServiceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
  
    ViewData["Title"] = "Our Team";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h3>MEET OUR TEAM</h3>\r\n\r\n    <hr class=\"my-4\">\r\n\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 21 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
     foreach (var employee in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <figure class=\"figure text-center responsive mr-auto col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35960a8d27966438dfe27e2fa4e2f5fb10999a8d6434", async() => {
                WriteLiteral("\r\n                <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 587, "\"", 608, 1);
#nullable restore
#line 25 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
WriteAttributeValue("", 593, employee.Image, 593, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-employeeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
                                                                         WriteLiteral(employee.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-employeeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["employeeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title text-center\">");
#nullable restore
#line 28 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
                                              Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 28 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
                                                                   Write(employee.LasttName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text text-center\">");
#nullable restore
#line 29 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
                                            Write(employee.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </figure>\r\n");
#nullable restore
#line 32 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Employees\Team.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeDetailsServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
