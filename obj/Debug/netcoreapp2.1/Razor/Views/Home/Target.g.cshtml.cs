#pragma checksum "C:\New folder\count1\Views\Home\Target.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51fb89253d3476fcf93c6f42f530514c6965304c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Target), @"mvc.1.0.view", @"/Views/Home/Target.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Target.cshtml", typeof(AspNetCore.Views_Home_Target))]
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
#line 1 "C:\New folder\count1\Views\_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "C:\New folder\count1\Views\_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51fb89253d3476fcf93c6f42f530514c6965304c", @"/Views/Home/Target.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Target : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 131, true);
            WriteLiteral("<div class=\"card\">\r\n<div class=\"container\">\r\n    <br>\r\n    <h5 class=\" dh right-align\">މިސަން އަދި ވިޝަން</h5>\r\n    <hr>\r\n<div>\r\n\r\n");
            EndContext();
#line 8 "C:\New folder\count1\Views\Home\Target.cshtml"
 foreach (var item in ViewBag.mission)
{

#line default
#line hidden
            BeginContext(174, 55, true);
            WriteLiteral("    <h5 class=\"dh right-align\" style=\"direction: rtl;\">");
            EndContext();
            BeginContext(230, 10, false);
#line 10 "C:\New folder\count1\Views\Home\Target.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(240, 44, true);
            WriteLiteral("</h5>\r\n    <p class=\"right-align\">\r\n        ");
            EndContext();
            BeginContext(285, 9, false);
#line 12 "C:\New folder\count1\Views\Home\Target.cshtml"
   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(294, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\New folder\count1\Views\Home\Target.cshtml"
}

#line default
#line hidden
            BeginContext(309, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 17 "C:\New folder\count1\Views\Home\Target.cshtml"
 foreach (var item in  ViewBag.Vission)
{

#line default
#line hidden
            BeginContext(357, 55, true);
            WriteLiteral("    <h5 class=\"dh right-align\" style=\"direction: rtl;\">");
            EndContext();
            BeginContext(413, 10, false);
#line 19 "C:\New folder\count1\Views\Home\Target.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(423, 47, true);
            WriteLiteral("</h5>\r\n    <p class=\"dh right-align\">\r\n        ");
            EndContext();
            BeginContext(471, 9, false);
#line 21 "C:\New folder\count1\Views\Home\Target.cshtml"
   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(480, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 23 "C:\New folder\count1\Views\Home\Target.cshtml"
}

#line default
#line hidden
            BeginContext(495, 28, true);
            WriteLiteral("<br>\r\n</div>\r\n</div>\r\n</div>");
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
