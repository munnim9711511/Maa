#pragma checksum "/count1/Views/Admin/ImportantLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90dcba0a7f52d18aee18f1ea0fee505ba722fa4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ImportantLocation), @"mvc.1.0.view", @"/Views/Admin/ImportantLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ImportantLocation.cshtml", typeof(AspNetCore.Views_Admin_ImportantLocation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90dcba0a7f52d18aee18f1ea0fee505ba722fa4c", @"/Views/Admin/ImportantLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ImportantLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ImportantLocation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/count1/Views/Admin/ImportantLocation.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(54, 75, true);
            WriteLiteral("\n\n<h5 class=\"dh\">\n  މާމިގިލީގައި ހުރި މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު\n</h5>\n");
            EndContext();
            BeginContext(129, 2518, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f256fac8eb4dd6a7413fa92a75c7ad", async() => {
                BeginContext(206, 2434, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col m4 s12 input-field"">
            <input type=""text"" style=""font-family:Faruma;direction:rtl;"" name=""Title""  required/>
            <label class=""dh"">
                  ނަން
            </label>
        </div>
    </div>
      <div class=""row"">
        <div class=""col m4 s12 input-field"">
            <input type=""text"" style=""font-family:Faruma;direction:rtl;"" name=""TitleEng""  required/>
            <label class=""dh"">
                  Name
            </label>
        </div>
    </div>
   
    <div class=""row"">
        <div class=""col m4 s12 "">
            <label>
                Image
            </label>
            <br />
            <input type=""file"" name=""pic"" required />

        </div>
    </div>
       <div class=""row"">
        <div class=""col m4 s12 "">
            <label>
                Image
            </label>
            <br />
            <input type=""file"" name=""pic"" required />

        </div>
    </div>
       <div class=""row"">
        <div cla");
                WriteLiteral(@"ss=""col m4 s12 "">
            <label>
                Image
            </label>
            <br />
            <input type=""file"" name=""pic"" required />

        </div>
    </div>
       <div class=""row"">
        <div class=""col m4 s12 "">
            <label>
                Image
            </label>
            <br />
            <input type=""file"" name=""pic"" required />

        </div>
    </div>
       <div class=""row"">
        <div class=""col m4 s12 "">
            <label>
                Image
            </label>
            <br />
            <input type=""file"" name=""pic"" required />

        </div>
    </div>
    <div class=""row"">
        <div class=""col m10 s12 input-field"">
            <i class=""material-icons prefix"">mode_edit</i>
            <textarea id=""icon_prefix2"" class=""materialize-textarea"" style=""font-family:Faruma;direction:rtl"" name=""Text"" required></textarea>
            <label>
                Info
            </label>
        </div>
    </div>
        <div class=""row"">
        <div cl");
                WriteLiteral(@"ass=""col m10 s12 input-field"">
            <i class=""material-icons prefix"">mode_edit</i>
            <textarea id=""icon_prefix2"" class=""materialize-textarea"" style="""" name=""TextEng"" required></textarea>
            <label>
                Info Eng
            </label>
        </div>
    </div>
    <div class=""row"">
      <input  type=""submit"" value=""upload"" class=""btn""/>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
