#pragma checksum "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e516d3150103554461559ebbb7c2b52d70c97cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_create), @"mvc.1.0.view", @"/Views/Employee/create.cshtml")]
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
#line 1 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\_ViewImports.cshtml"
using Assignmentmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\_ViewImports.cshtml"
using Assignmentmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e516d3150103554461559ebbb7c2b52d70c97cb", @"/Views/Employee/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae6774dd4bd384e35915a8a98aadf9f3499c52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
  
    ViewData["Title"] = "create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>create</h1>\r\n");
#nullable restore
#line 7 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <thead>Registration form</thead>\r\n    <tr>\r\n        <td>Employee Id</td>\r\n        <td>");
#nullable restore
#line 13 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
       Write(Html.TextBox("Eid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Employee Name</td>\r\n        <td>");
#nullable restore
#line 17 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
       Write(Html.TextBox("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td> Desigantion</td>\r\n        <td>");
#nullable restore
#line 21 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
       Write(Html.DropDownListFor(m=>m.Desig,ViewData["Desig"] as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Project Name</td>\r\n\r\n        <td>");
#nullable restore
#line 26 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
       Write(Html.DropDownListFor(m=>m.Proname,ViewData["Proname"] as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 30 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
       Write(Html.Password("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><input type=\"submit\" value=\"Register\" /></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 36 "D:\Hamsitha\22-1-2020\Assignmentmvc\Views\Employee\create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
