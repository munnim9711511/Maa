#pragma checksum "/count1/Views/EngPage/GuestHouseEn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41263aaf7edd667be5d75485a9df11b7183ad015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EngPage_GuestHouseEn), @"mvc.1.0.view", @"/Views/EngPage/GuestHouseEn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EngPage/GuestHouseEn.cshtml", typeof(AspNetCore.Views_EngPage_GuestHouseEn))]
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
#line 1 "/count1/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/count1/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41263aaf7edd667be5d75485a9df11b7183ad015", @"/Views/EngPage/GuestHouseEn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_EngPage_GuestHouseEn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 197, true);
            WriteLiteral("<div class=\"card\">\n<div class=\"container center-align\">\n    <br>\n   <h5 class=\"left-align\">\n      Guest Houses\n   </h5>\n   <hr>\n<div class=\"row\">\n    <div class=\"col s12  left-align\">\n        <ul>\n");
            EndContext();
#line 11 "/count1/Views/EngPage/GuestHouseEn.cshtml"
                   foreach (var item in  ViewBag.ghouseEn)
        {

#line default
#line hidden
            BeginContext(266, 35, true);
            WriteLiteral("            <li>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 301, "\"", 364, 1);
#line 14 "/count1/Views/EngPage/GuestHouseEn.cshtml"
WriteAttributeValue("", 308, Url.Action("GuestHouseEngInfo","Link",new{id=@item.Id}), 308, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 25, true);
            WriteLiteral(">\n                       ");
            EndContext();
            BeginContext(391, 13, false);
#line 15 "/count1/Views/EngPage/GuestHouseEn.cshtml"
                  Write(item.TitleEng);

#line default
#line hidden
            EndContext();
            BeginContext(404, 54, true);
            WriteLiteral("\n                </a>\n             \n            </li>\n");
            EndContext();
#line 19 "/count1/Views/EngPage/GuestHouseEn.cshtml"
      
        }

#line default
#line hidden
            BeginContext(475, 56, true);
            WriteLiteral("        </ul>\n  \n       \n    </div>\n</div>\n</div>\n</div>");
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
