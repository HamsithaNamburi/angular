#pragma checksum "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e63b92836a502f68b60744f0507d3ca69838757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "D:\Hamsitha\21-1-2020\Employee\Views\_ViewImports.cshtml"
using Employee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e63b92836a502f68b60744f0507d3ca69838757", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f5744fcae37ab1b6f9f2ee1f52ed097bfd5b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyEmployee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <table border=\"1\">\r\n        <thead>Employees details</thead>\r\n        <tr>\r\n            <td> ID </td>\r\n            <td>Name</td>\r\n            <td>Email</td>\r\n            <td>Dept</td>\r\n        </tr>\r\n        \r\n");
#nullable restore
#line 23 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"
            foreach(var eli in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 26 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"
       Write(eli.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td>");
#nullable restore
#line 27 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"
       Write(eli.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"
       Write(eli.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"
       Write(eli.Dept);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "D:\Hamsitha\21-1-2020\Employee\Views\Employee\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyEmployee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
