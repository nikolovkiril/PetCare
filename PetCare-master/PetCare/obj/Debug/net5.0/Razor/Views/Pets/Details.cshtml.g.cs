#pragma checksum "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16df05a92f84de084175b1d9727c8d69e6118d04"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16df05a92f84de084175b1d9727c8d69e6118d04", @"/Views/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46936b54303aca6a77afd3e20a5204b1538af850", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DetailsPetFormModel>>
    {
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
            WriteLiteral(@"

<div class=""container col-sm-12 offset-lg-2 col-lg-6 offset-xl-3 col-xl-6"">
    <h2 class=""text-center"">Pet Details</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Age</th>
                <th>Animal</th>
                <th>Breed</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
             foreach (var pet in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(pet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(pet.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(pet.AnimalType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(pet.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
                   Write(pet.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "D:\Code C#\PetCare\PetCare-master\PetCare\Views\Pets\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DetailsPetFormModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
