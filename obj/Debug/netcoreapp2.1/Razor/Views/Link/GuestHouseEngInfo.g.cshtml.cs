#pragma checksum "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2098b233148c690c9c77b863e3363ad95e04c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_GuestHouseEngInfo), @"mvc.1.0.view", @"/Views/Link/GuestHouseEngInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/GuestHouseEngInfo.cshtml", typeof(AspNetCore.Views_Link_GuestHouseEngInfo))]
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
#line 1 "/home/munnim/Desktop/Maa/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/Maa/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2098b233148c690c9c77b863e3363ad95e04c4", @"/Views/Link/GuestHouseEngInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_GuestHouseEngInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 73, true);
            WriteLiteral("<div class=\"container\">\n\n<div class=\" \" style=\"padding: 12px;\">\n\n<br>\n\n\n\n");
            EndContext();
#line 9 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
         foreach (var item in ViewBag.GuestInfo)
{


#line default
#line hidden
            BeginContext(125, 85, true);
            WriteLiteral("      <h5 class=\"dh left-align\" style=\"direction: rtl;\">\n       \n       <em>\n        ");
            EndContext();
            BeginContext(211, 10, false);
#line 15 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(221, 25, true);
            WriteLiteral("\n\n       </em>\n    </h5>\n");
            EndContext();
            BeginContext(248, 68, true);
            WriteLiteral("   <div class=\"slider\">\n    <ul class=\"slides\">\n       <li>\n        ");
            EndContext();
            BeginContext(316, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b8dc5d15700419996c8ff193456888e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 326, "~/GuestHousePic/", 326, 16, true);
#line 24 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
AddHtmlAttributeValue("", 342, item.ImgUrl1, 342, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(357, 56, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n       <li>\n        ");
            EndContext();
            BeginContext(413, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8119128c61c4ad9b10fe7064224015b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/GuestHousePic/", 423, 16, true);
#line 28 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
AddHtmlAttributeValue("", 439, item.ImgUrl2, 439, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 58, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n         <li>\n        ");
            EndContext();
            BeginContext(512, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e66fea2139744d2a062989cb215b38d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 522, "~/GuestHousePic/", 522, 16, true);
#line 32 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
AddHtmlAttributeValue("", 538, item.ImgUrl3, 538, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(553, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(615, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1f8f4ef7c3c43bc98e5326a2156200b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 625, "~/GuestHousePic/", 625, 16, true);
#line 36 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
AddHtmlAttributeValue("", 641, item.ImgUrl4, 641, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(656, 62, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n             <li>\n        ");
            EndContext();
            BeginContext(718, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ed4d46f42464258ba134e8fefb081f9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 728, "~/GuestHousePic/", 728, 16, true);
#line 40 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
AddHtmlAttributeValue("", 744, item.ImgUrl5, 744, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(759, 170, true);
            WriteLiteral(" <!-- random image -->\n\n      </li>\n          </ul>\n  </div>\n  <div style=\"padding: 15px;\">\n    <p class=\" dh left-align\" style=\"font-size: 19px;\">\n phone number: 00 960 ");
            EndContext();
            BeginContext(930, 19, false);
#line 47 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
                 Write(item.ConatactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(949, 76, true);
            WriteLiteral(" \n</p>\n    <p class=\" dh left-align\" style=\"font-size: 19px;\" >\n    Email : ");
            EndContext();
            BeginContext(1026, 10, false);
#line 50 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 82, true);
            WriteLiteral(" \n</p>\n\n<p class=\"dh left-align\" style=\"font-size: 19px; text-align: justify;\">\n  ");
            EndContext();
            BeginContext(1119, 9, false);
#line 54 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"
Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 15, true);
            WriteLiteral("\n</p>\n  </div>\n");
            EndContext();
#line 57 "/home/munnim/Desktop/Maa/Views/Link/GuestHouseEngInfo.cshtml"


}

#line default
#line hidden
            BeginContext(1147, 52, true);
            WriteLiteral("\n\n\n\n\n</div>\n\n<div class=\"container\">\n\n</div>\n</div>\n");
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
