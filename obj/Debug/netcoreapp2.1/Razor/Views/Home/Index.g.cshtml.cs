#pragma checksum "C:\New folder\count1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e50e0eaed6ec0b3e311f24a453a36f8778270b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50e0eaed6ec0b3e311f24a453a36f8778270b53", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/red-circle-with-pdf-icon-png-20.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25px;padding-left: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 85%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\New folder\count1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 59, true);
            WriteLiteral("\r\n\r\n    <div class=\"slider\">\r\n        <ul class=\"slides\">\r\n");
            EndContext();
#line 8 "C:\New folder\count1\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.slider)
            {

#line default
#line hidden
            BeginContext(170, 42, true);
            WriteLiteral("                <li>\r\n                    ");
            EndContext();
            BeginContext(212, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7222c87d81014a63ae791bbc2429b22c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 222, "~/slideImage/", 222, 13, true);
#line 11 "C:\New folder\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 235, item.ImgUrl, 235, 12, false);

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
            BeginContext(249, 47, true);
            WriteLiteral(" <!-- random image -->\r\n                </li>\r\n");
            EndContext();
#line 13 "C:\New folder\count1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(311, 330, true);
            WriteLiteral(@"        </ul>
    </div>

<div class=""card grey lighten-4"">
     <div class=""row"">
           <div class=""col s12 m4"">
               
                   <div class=""card-content"">
             <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>    ގެލަރީ   </strong></h5><hr>
        <div class=""container"">
");
            EndContext();
#line 24 "C:\New folder\count1\Views\Home\Index.cshtml"
         foreach (var item in ViewBag.gallery)
          {

#line default
#line hidden
            BeginContext(702, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(716, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79073c6ed019494aaa863b274ceb8fee", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 726, "~/gallery/", 726, 10, true);
#line 26 "C:\New folder\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 736, item.ImgUrl, 736, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(771, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 27 "C:\New folder\count1\Views\Home\Index.cshtml"
             }

#line default
#line hidden
            BeginContext(793, 570, true);
            WriteLiteral(@"        </div>
        
             </div>
             
                 <div class=""card-content"">
        <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>    އިސްތިހާރު   </strong></h5><hr>
                 </div>
              
        </div>
           
           <div class=""col s12 m4"">
               
                   <div class=""card-content"">
               <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>   ފަހުގެ އެންގުންތައް   </strong></h5><hr>
               </div>
               <div class=""container"">
");
            EndContext();
#line 44 "C:\New folder\count1\Views\Home\Index.cshtml"
                foreach (var item in ViewBag.anouncements)
                  {

#line default
#line hidden
            BeginContext(1444, 141, true);
            WriteLiteral("          <ul class=\"right-align\">\r\n              <li style=\"font-family: Faruma;direction: rtl;font-size: 20px;\">\r\n              <a href=\"\">");
            EndContext();
            BeginContext(1585, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df6ee3e51ca94353a23feb37e6ac0b9a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1685, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1687, 10, false);
#line 48 "C:\New folder\count1\Views\Home\Index.cshtml"
                                                                                                                         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1697, 46, true);
            WriteLiteral("</a>\r\n             </li>\r\n          </ul>   \r\n");
            EndContext();
#line 51 "C:\New folder\count1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
            BeginContext(1765, 349, true);
            WriteLiteral(@"                      </div>
                   
           </div>

           <div class=""col s12 m4"">
            
                   <div class=""card-content"">
               <h5 class=""dh center-align"" style=""font-size: 20px;"" ><strong>   ފަހުގެ ޙަބަރު   </strong></h5><hr>
               </div>
               <div class=""container"">
");
            EndContext();
#line 62 "C:\New folder\count1\Views\Home\Index.cshtml"
                foreach (var item in ViewBag.news)
                    {

#line default
#line hidden
            BeginContext(2189, 65, true);
            WriteLiteral("           <div class=\"row\">\r\n               <div class=\"col s4\">");
            EndContext();
            BeginContext(2254, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5bc9dcb3fa5c4278a02a71cd636f4651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2264, "~/newsImage/", 2264, 12, true);
#line 65 "C:\New folder\count1\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2276, item.ImgUrl, 2276, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2333, 106, true);
            WriteLiteral("</div>\r\n                <div class=\"col s8 right-align\"><a class=\"dh right-align\" style=\"font-size: 19px;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2439, "\"", 2491, 1);
#line 66 "C:\New folder\count1\Views\Home\Index.cshtml"
WriteAttributeValue("", 2446, Url.Action("Index","News",new{id =@item.Id}), 2446, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2492, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2494, 10, false);
#line 66 "C:\New folder\count1\Views\Home\Index.cshtml"
                                                                                                                                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2504, 48, true);
            WriteLiteral("</a></div>\r\n           </div>\r\n           <hr>\r\n");
            EndContext();
#line 69 "C:\New folder\count1\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
            BeginContext(2574, 103, true);
            WriteLiteral("                   </div>\r\n                   \r\n           </div>\r\n\r\n          </div>\r\n \r\n </div>\r\n    ");
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
