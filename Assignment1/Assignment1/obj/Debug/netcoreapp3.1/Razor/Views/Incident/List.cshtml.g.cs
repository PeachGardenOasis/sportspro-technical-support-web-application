#pragma checksum "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a814a7b3ea396e4d46683d637c89886679ce70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incident_List), @"mvc.1.0.view", @"/Views/Incident/List.cshtml")]
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
#line 1 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11a814a7b3ea396e4d46683d637c89886679ce70", @"/Views/Incident/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Incident_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Incident>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
  
    ViewData["Title"] = "Incident Manager";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Incident Manager</h3>\r\n<table>\r\n    <thead>\r\n        <tr>Title</tr>\r\n        <tr>Customer</tr>\r\n        <tr>Product</tr>\r\n        <tr>Date Opened</tr>\r\n        <tr></tr>\r\n        <tr></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
         foreach(Incident incident in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
               Write(incident.incidentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
               Write(incident.incidentCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
               Write(incident.incidentProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
               Write(incident.dateOpened);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Temporary Edit</td>\r\n                <td>Temporary Delete</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\simon\Documents\`School\`T127 SEM 4\[C#] Web Application Development\assignments\Assignment1\Assignment1\Assignment1\Views\Incident\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Incident>> Html { get; private set; }
    }
}
#pragma warning restore 1591
