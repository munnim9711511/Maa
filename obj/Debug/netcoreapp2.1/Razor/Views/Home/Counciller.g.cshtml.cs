#pragma checksum "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a4d538cde23646d83f5d15a4ac0f5c0d315de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Counciller), @"mvc.1.0.view", @"/Views/Home/Counciller.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Counciller.cshtml", typeof(AspNetCore.Views_Home_Counciller))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a4d538cde23646d83f5d15a4ac0f5c0d315de4", @"/Views/Home/Counciller.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Counciller : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded z-depth-1 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("team member"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("180px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("180px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 167, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <br>\r\n<div class=\"container\">\r\n    <h5 class=\"dh right-align\">  ކައުންސިލަރގެ މަޢުލޫމާތު</h5>\r\n    <hr>\r\n<div class=\"row center-align\">\r\n\r\n\r\n");
            EndContext();
#line 10 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
 foreach (var item in ViewBag.conciller)
{
  

#line default
#line hidden
            BeginContext(216, 82, true);
            WriteLiteral("    <div class=\"wow fadeIn\">\r\n      <h2 class=\"h1 h1-responsive text-center my-5\">");
            EndContext();
            BeginContext(299, 10, false);
#line 14 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
                                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(309, 175, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n    <div class=\"center-align\">\r\n      <div class=\"col-lg-6 col-md-12 mb-5 wow fadeInLeft\">\r\n        <div class=\"col-md-6 float-left\">");
            EndContext();
            BeginContext(484, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf303ac8fa5c463ead928bfe6965f3b0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 535, "~/council/", 535, 10, true);
#line 19 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 545, item.FirstPic, 545, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(609, 82, true);
            WriteLiteral("</div>\r\n        <div class=\"col-md-6 float-right\">\r\n          <div class=\"h4 dh\"> ");
            EndContext();
            BeginContext(692, 14, false);
#line 21 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
                         Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(706, 271, true);
            WriteLiteral(@"</div>
          <h6 class=""h6 blue-grey-text mb-3 dh "" style=""direction: rtl;"">ކައުންސިލްގެ ރައީސް </h6>
        </div>
      </div>
      </div>  
      <div class=""row"">
        <div class=""center-align"">
      <div class=""col s12 m6"">
        
        <div >");
            EndContext();
            BeginContext(977, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11a65c0544634e8a9cf645709f90176e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1028, "~/council/", 1028, 10, true);
#line 30 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1038, item.TheirdPic, 1038, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1103, 50, true);
            WriteLiteral("</div>\r\n        <div >\r\n          <div class=\"h4\">");
            EndContext();
            BeginContext(1154, 15, false);
#line 32 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
                     Write(item.TheirdName);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 213, true);
            WriteLiteral("</div>\r\n          <h6 class=\"h6 blue-grey-text mb-3 dh\">ކައުންސިލަރ </h6>\r\n          \r\n        </div>\r\n      </div>\r\n      </div>\r\n\r\n      <div class=\"center-align\">\r\n      <div class=\"col s12 m6\">\r\n        <div >");
            EndContext();
            BeginContext(1382, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecfb19d8574348a18915bc205a820594", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1433, "~/council/", 1433, 10, true);
#line 41 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
AddHtmlAttributeValue("", 1443, item.SecondPic, 1443, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1508, 50, true);
            WriteLiteral("</div>\r\n        <div >\r\n          <div class=\"h4\">");
            EndContext();
            BeginContext(1559, 15, false);
#line 43 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
                     Write(item.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(1574, 206, true);
            WriteLiteral("</div>\r\n          \r\n          <h6 class=\"h6 blue-grey-text mb-3 dh\" style=\"direction: rtl;\">ކައުންސިލްގެ ނައިބް ރައީސް  </h6>\r\n          \r\n        </div>\r\n      </div>\r\n      </div>\r\n\r\n  </div>\r\n \r\n</div>\r\n");
            EndContext();
#line 54 "/home/munnim/Desktop/count1/Views/Home/Counciller.cshtml"
}

#line default
#line hidden
            BeginContext(1783, 30, true);
            WriteLiteral("\r\n\r\n</div>\r\n</div>\r\n\r\n\r\n</div>");
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
