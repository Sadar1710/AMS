#pragma checksum "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9b7778f156b628d92105ad7115d13df07c1801a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_InboxReadMessage), @"mvc.1.0.view", @"/Views/Faculty/InboxReadMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Faculty/InboxReadMessage.cshtml", typeof(AspNetCore.Views_Faculty_InboxReadMessage))]
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
#line 1 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\_ViewImports.cshtml"
using AttendenceManagementSystem;

#line default
#line hidden
#line 2 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\_ViewImports.cshtml"
using AttendenceManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b7778f156b628d92105ad7115d13df07c1801a", @"/Views/Faculty/InboxReadMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528f9538927821b5160986825edc5a5130bb5c39", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_InboxReadMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
  
    ViewData["Title"] = "InboxReadMessage";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 33, false);
#line 6 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
Write(Html.Partial("_FacultyDashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(90, 303, true);
            WriteLiteral(@"

    <div class=""container"">
        <div class=""container-fluid"" style=""padding-top:60px;padding-bottom:60px;position:relative;"">
            <div class=""card"" style=""margin-left: 50%;transform: translateX(-50%);width:80%;"">
                <div class=""card-body"">
                    <h6>From:-");
            EndContext();
            BeginContext(394, 15, false);
#line 12 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                         Write(ViewBag.grdname);

#line default
#line hidden
            EndContext();
            BeginContext(409, 35, true);
            WriteLiteral("</h6>\r\n                    <h6>To:-");
            EndContext();
            BeginContext(445, 19, false);
#line 13 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                       Write(ViewBag.facultyname);

#line default
#line hidden
            EndContext();
            BeginContext(464, 37, true);
            WriteLiteral("</h6>\r\n                    <h6>Date:-");
            EndContext();
            BeginContext(502, 15, false);
#line 14 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                         Write(ViewBag.msgdate);

#line default
#line hidden
            EndContext();
            BeginContext(517, 37, true);
            WriteLiteral("</h6>\r\n                    <h6>Time:-");
            EndContext();
            BeginContext(555, 15, false);
#line 15 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                         Write(ViewBag.msgtime);

#line default
#line hidden
            EndContext();
            BeginContext(570, 129, true);
            WriteLiteral("</h6>\r\n                    <br>\r\n                    <h6 style=\"text-decoration:underline;\">Title:-</h6>\r\n                    <p>");
            EndContext();
            BeginContext(700, 16, false);
#line 18 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                  Write(ViewBag.msgtitle);

#line default
#line hidden
            EndContext();
            BeginContext(716, 104, true);
            WriteLiteral("</p>\r\n                    <h6 style=\"text-decoration:underline;\">Message:-</h6>\r\n                    <p>");
            EndContext();
            BeginContext(821, 17, false);
#line 20 "F:\IUBAT\AttendenceManagementSystem\AttendenceManagementSystem\Views\Faculty\InboxReadMessage.cshtml"
                  Write(ViewBag.msgdetail);

#line default
#line hidden
            EndContext();
            BeginContext(838, 80, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
