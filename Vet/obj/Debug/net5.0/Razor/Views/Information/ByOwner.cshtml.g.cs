#pragma checksum "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27d37b5e2f2240cdadcb7140a07c17e35949f068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Information_ByOwner), @"mvc.1.0.view", @"/Views/Information/ByOwner.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d37b5e2f2240cdadcb7140a07c17e35949f068", @"/Views/Information/ByOwner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d857119458fb2584755616faf8d842a76bb13a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Information_ByOwner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vet.MyModels.Info>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 5 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
  
    var name = "";
    var headerTr = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h6>Prueba</h6>\r\n<div class=\"container\" id=\"result\">\r\n");
#nullable restore
#line 12 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
     foreach (var columnData in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
         if (name != @columnData.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt>\r\n                <h3>");
#nullable restore
#line 17 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
               Write(columnData.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pet </h3><h6>(");
#nullable restore
#line 17 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                                              Write(columnData.HomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                                                                       Write(columnData.Cellphone);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n            </dt>\r\n");
#nullable restore
#line 19 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"

            name = @columnData.Name;
            headerTr = 1;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-10\">\r\n            <table class=\"table\">\r\n");
#nullable restore
#line 26 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                 if (headerTr == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
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
");
#nullable restore
#line 40 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                    headerTr = 0;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.PetName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Specie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Race);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
                   Write(columnData.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1669, "\"", 1797, 5);
            WriteAttributeValue("", 1679, "document.location.href", 1679, 22, true);
            WriteAttributeValue(" ", 1701, "=", 1702, 2, true);
            WriteAttributeValue(" ", 1703, "\'", 1704, 2, true);
#nullable restore
#line 55 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
WriteAttributeValue("", 1705, Url.Content("~/Pet/Edit/?id="+columnData.PetId+"="+columnData.OwnerId+"="+columnData.Name), 1705, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1796, "\'", 1796, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" id=\"edit\">Edit</button>\r\n                    </td>\r\n\r\n                </tr>\r\n\r\n            </table>\r\n        </dd>\r\n");
#nullable restore
#line 62 "C:\Users\FFernandez\source\repos\Vet\Vet\Views\Information\ByOwner.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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

    <br />
    <br />

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vet.MyModels.Info>> Html { get; private set; }
    }
}
#pragma warning restore 1591
