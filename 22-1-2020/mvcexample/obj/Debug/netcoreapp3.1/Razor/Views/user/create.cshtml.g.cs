#pragma checksum "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "962ae23cbf0faeb7da848d162759f2825590d2e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_user_create), @"mvc.1.0.view", @"/Views/user/create.cshtml")]
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
#line 1 "D:\Hamsitha\22-1-2020\mvcexample\Views\_ViewImports.cshtml"
using mvcexample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hamsitha\22-1-2020\mvcexample\Views\_ViewImports.cshtml"
using mvcexample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"962ae23cbf0faeb7da848d162759f2825590d2e8", @"/Views/user/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790c12150454634dabcbd72f23c23074c1cadb26", @"/Views/_ViewImports.cshtml")]
    public class Views_user_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<user>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
  
    ViewData["Title"] = "create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>create</h1>\r\n");
#nullable restore
#line 9 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <thead>User Details</thead>\r\n    <tr>\r\n        <td>Name</td>\r\n       \r\n        <td>");
#nullable restore
#line 16 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m=>m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td>DOB</td>\r\n        <td>");
#nullable restore
#line 22 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.TextBoxFor(m => m.DOB, null, new { @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email</td>\r\n        <td>");
#nullable restore
#line 27 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>mobile_no</td>\r\n        <td>");
#nullable restore
#line 32 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.TextBoxFor(m => m.mobile_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.mobile_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>country</td>\r\n        <td>");
#nullable restore
#line 37 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.DropDownListFor(m => m.country, new SelectList(new string[] {"", "India", "China", "Us", "Uk" })));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 39 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>username</td>\r\n        <td>");
#nullable restore
#line 43 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.TextBox("uname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>password</td>\r\n        <td>");
#nullable restore
#line 48 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.Password("pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 49 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
       Write(Html.ValidationMessageFor(m => m.pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n            <input type=\"submit\" value=\"Register\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 58 "D:\Hamsitha\22-1-2020\mvcexample\Views\user\create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<user> Html { get; private set; }
    }
}
#pragma warning restore 1591
