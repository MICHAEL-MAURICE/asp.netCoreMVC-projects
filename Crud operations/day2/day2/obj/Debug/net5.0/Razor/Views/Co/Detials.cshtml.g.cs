#pragma checksum "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2bd4108491ec100b480e56cec77507b7cdb74ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Co_Detials), @"mvc.1.0.view", @"/Views/Co/Detials.cshtml")]
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
#line 1 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\_ViewImports.cshtml"
using day2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\_ViewImports.cshtml"
using day2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2bd4108491ec100b480e56cec77507b7cdb74ea", @"/Views/Co/Detials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab5b760ade519231f643658573cd11ca7b9c216", @"/Views/_ViewImports.cshtml")]
    public class Views_Co_Detials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Instuctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n  <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 89, "\"", 113, 2);
            WriteAttributeValue("", 95, "/imgs/", 95, 6, true);
#nullable restore
#line 4 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml"
WriteAttributeValue("", 101, Model.Image, 101, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n  <div class=\"card-body\">\r\n    <ul class=\"list-group list-group-flush\">\r\n    <li class=\"list-group-item\">id: ");
#nullable restore
#line 7 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Name: ");
#nullable restore
#line 8 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Adress: ");
#nullable restore
#line 9 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml"
                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n     <li class=\"list-group-item\">Salary: ");
#nullable restore
#line 10 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\Detials.cshtml"
                                    Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n    <li class=\"list-group-item\">\r\n        <a href=\"http://localhost:55420/Co/Index\" class=\"card-link btn btn-primary\">back</a>\r\n        \r\n    \r\n    \r\n    </li>\r\n  </ul>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Instuctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
