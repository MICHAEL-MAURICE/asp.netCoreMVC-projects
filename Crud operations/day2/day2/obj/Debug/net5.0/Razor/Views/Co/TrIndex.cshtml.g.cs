#pragma checksum "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402ec0c274eb31ca3643b2530e143a9384ba5aad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Co_TrIndex), @"mvc.1.0.view", @"/Views/Co/TrIndex.cshtml")]
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
#nullable restore
#line 1 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
using day2.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402ec0c274eb31ca3643b2530e143a9384ba5aad", @"/Views/Co/TrIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dab5b760ade519231f643658573cd11ca7b9c216", @"/Views/_ViewImports.cshtml")]
    public class Views_Co_TrIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TranieeStudentDegree>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <h1>  sfjasdjpojdfpoajofpdsjjpfojdpjjf</h1>\r\n");
#nullable restore
#line 6 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
  foreach (var item in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card text-center mt-2 \">\r\n  \r\n  <div class=\"card-body\">\r\n    <ul class=\"list-group list-group-flush\">\r\n    <li class=\"list-group-item\">name: ");
#nullable restore
#line 12 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
                                 Write(item.Trename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">Degrww: ");
#nullable restore
#line 13 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
                                   Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
      if (@item.Status)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item bg-success\"> Pass </li>\r\n");
#nullable restore
#line 17 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item bg-danger\">Fail</li>\r\n");
#nullable restore
#line 21 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"list-group-item\">\r\n        \r\n        \r\n    </li>\r\n  </ul>\r\n  </div>\r\n</div>\r\n");
#nullable restore
#line 29 "D:\itiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii\c#\MVC\day2\day2\day2\Views\Co\TrIndex.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TranieeStudentDegree>> Html { get; private set; }
    }
}
#pragma warning restore 1591
