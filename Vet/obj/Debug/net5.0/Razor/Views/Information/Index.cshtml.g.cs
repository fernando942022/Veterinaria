#pragma checksum "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661df2d96dcf5c24996d693d6967fa5cd5d1a74d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Information_Index), @"mvc.1.0.view", @"/Views/Information/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661df2d96dcf5c24996d693d6967fa5cd5d1a74d", @"/Views/Information/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d857119458fb2584755616faf8d842a76bb13a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Information_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vet.Models.Pet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Customer</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Image</th>
            <th>BirthDate</th>
            <th>Age</th>
            <th>Sex</th>
            <th>Specie</th>
            <th>Race</th>
            <th>Color</th>
            <th>Weigth</th>
            <th>Comments</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 22 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
         foreach (var columnData in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Specie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Race);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
               Write(columnData.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 993, "\"", 1121, 5);
            WriteAttributeValue("", 1003, "document.location.href", 1003, 22, true);
            WriteAttributeValue(" ", 1025, "=", 1026, 2, true);
            WriteAttributeValue(" ", 1027, "\'", 1028, 2, true);
#nullable restore
#line 36 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
WriteAttributeValue("", 1029, Url.Content("~/Pet/Edit/?id="+columnData.PetId+"="+columnData.OwnerId+"="+columnData.Name), 1029, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1120, "\'", 1120, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" id=\"edit\">Edit</button>\r\n                </td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<br />
<br />


<!--<dt class=""col-sm-2"">
    <label>hola</label>
</dt>
<dd class=""col-sm-10"">
    <label>hola</label>
</dd>

<dt class=""col-sm-2"">
    <label>hola</label>
</dt>
<dd class=""col-sm-10"">
    <table class=""table"">
        <tr>
            <th>Course Title</th>
            <th>Grade</th>
        </tr>

    </table>
</dd>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vet.Models.Pet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
