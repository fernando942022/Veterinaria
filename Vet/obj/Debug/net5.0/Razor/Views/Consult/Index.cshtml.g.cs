#pragma checksum "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5503842ff0d3dc7525da690a8f308b642f31bf48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consult_Index), @"mvc.1.0.view", @"/Views/Consult/Index.cshtml")]
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
#line 1 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\_ViewImports.cshtml"
using Vet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\_ViewImports.cshtml"
using Vet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5503842ff0d3dc7525da690a8f308b642f31bf48", @"/Views/Consult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d857119458fb2584755616faf8d842a76bb13a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Consult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vet.Models.Consult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Consults.</h3><br />\r\n\r\n<button class=\"btn btn-primary\" id=\"newConsult\"");
            BeginWriteAttribute("onclick", " onclick=\"", 110, "\"", 186, 5);
            WriteAttributeValue("", 120, "document.location.href", 120, 22, true);
            WriteAttributeValue(" ", 142, "=", 143, 2, true);
            WriteAttributeValue(" ", 144, "\'", 145, 2, true);
#nullable restore
#line 5 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
WriteAttributeValue("", 146, Url.Content("~/Consult/Add/?id=0=new"), 146, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 185, "\'", 185, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" >+ Create New Consult</button><br /><br />

<table class=""table"">
    <thead>
        <tr>
            <th>Owner Name</th>
            <th>Pet NAme</th>
            <th>Consult Date</th>
            <th>Pet Weight</th>
            <th>Temperature</th>
            <th>Medical Chart</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
         foreach (var columnData in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.PetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.ConsultDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.PetWeight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.PetTemperature);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
               Write(columnData.MedicalChart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Consult\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vet.Models.Consult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
