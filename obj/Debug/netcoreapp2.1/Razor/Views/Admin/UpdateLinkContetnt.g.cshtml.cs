#pragma checksum "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10a5084ac99c12f6959e3b193b4c028511ad2ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateLinkContetnt), @"mvc.1.0.view", @"/Views/Admin/UpdateLinkContetnt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateLinkContetnt.cshtml", typeof(AspNetCore.Views_Admin_UpdateLinkContetnt))]
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
#line 1 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/count1/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a5084ac99c12f6959e3b193b4c028511ad2ecd", @"/Views/Admin/UpdateLinkContetnt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateLinkContetnt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(54, 34, true);
            WriteLiteral("\n<h5>ލިންކް އަޕްޑޭޓް ކުރުން</h5>\n\n");
            EndContext();
#line 7 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
     foreach (var item in ViewBag.Link)
    {

#line default
#line hidden
            BeginContext(134, 13, true);
            WriteLiteral("       <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 147, "\"", 210, 1);
#line 9 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
WriteAttributeValue("", 154, Url.Action("IndividualUpdate","Admin",new{id=@item.Id}), 154, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(211, 37, true);
            WriteLiteral(" class=\"dh \" style=\"direction: rtl;\">");
            EndContext();
            BeginContext(249, 10, false);
#line 9 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
                                                                                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(259, 8, true);
            WriteLiteral(" <span>(");
            EndContext();
            BeginContext(268, 13, false);
#line 9 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
                                                                                                                                Write(item.Catogary);

#line default
#line hidden
            EndContext();
            BeginContext(281, 19, true);
            WriteLiteral(")</span></a></li> \n");
            EndContext();
#line 10 "/home/munnim/Desktop/count1/Views/Admin/UpdateLinkContetnt.cshtml"
    }

#line default
#line hidden
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
