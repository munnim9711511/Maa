#pragma checksum "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3265fd35f25345c3b22d13e6b3ace3fbf0b51fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminLayout.cshtml", typeof(AspNetCore.Views_Shared__AdminLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3265fd35f25345c3b22d13e6b3ace3fbf0b51fbb", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icon/admin.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(24, 825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7028e35b3168400091d57b508b07326d", async() => {
                BeginContext(30, 118, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
                EndContext();
                BeginContext(149, 17, false);
#line 7 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(166, 24, true);
                WriteLiteral(" - coouncil</title>\n    ");
                EndContext();
                BeginContext(190, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a89ce9016b647518066fb1a3862fdbf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(235, 99, true);
                WriteLiteral("\n\n      <link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\n    ");
                EndContext();
                BeginContext(334, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3673dfade48f4e5faba98bc14a38cd8b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(382, 412, true);
                WriteLiteral(@"
     <!-- Compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
    <!-- <link  rel=""stylesheet"" href=""~\materialize\css\materialize.min.css""> -->

    <!-- Compiled and minified JavaScript -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js""></script>
            

    ");
                EndContext();
                BeginContext(794, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc9b151253d84f38aeb324e3f0f0f87f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(830, 12, true);
                WriteLiteral("\n    \n\n\n   \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(849, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(850, 1290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf14c5732074a3fb398b7a0582d330b", async() => {
                BeginContext(857, 181, true);
                WriteLiteral("\n    <nav class=\"#212121 grey darken-4\">\n\n    </nav>\n   \n\n  <ul id=\"slide-out\" class=\"sidenav\">\n    <li><div class=\"user-view center-align\">\n      <div class=\"background\" >\n        ");
                EndContext();
                BeginContext(1038, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1f128033fb4141fbb521da9045f947df", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1082, 77, true);
                WriteLiteral("\n      </div>\n      <br><br> <br>\n      <br>\n     \n    </div></li>\n\n    <!-- ");
                EndContext();
                BeginContext(1160, 4, false);
#line 42 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
    Write(User);

#line default
#line hidden
                EndContext();
                BeginContext(1164, 5, true);
                WriteLiteral(" -->\n");
                EndContext();
#line 43 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
     if(User.IsInRole("Administrator"))
    {

#line default
#line hidden
                BeginContext(1215, 10, true);
                WriteLiteral("    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1225, "\"", 1260, 1);
#line 45 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1232, Url.Action("Users","Admin"), 1232, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1261, 22, true);
                WriteLiteral(">manage user</a></li>\n");
                EndContext();
#line 46 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"

    }

#line default
#line hidden
                BeginContext(1290, 54, true);
                WriteLiteral("  \n    <li><div class=\"divider\"></div></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1344, "\"", 1378, 1);
#line 50 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1351, Url.Action("News","Admin"), 1351, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1379, 32, true);
                WriteLiteral(">upload news</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1411, "\"", 1447, 1);
#line 51 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1418, Url.Action("Slider","Admin"), 1418, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1448, 27, true);
                WriteLiteral(">slider</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1475, "\"", 1514, 1);
#line 52 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1482, Url.Action("UploadDoc","Admin"), 1482, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1515, 31, true);
                WriteLiteral(">upload doc</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1546, "\"", 1586, 1);
#line 53 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1553, Url.Action("UpdateLink","Admin"), 1553, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1587, 36, true);
                WriteLiteral(">update url link</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1623, "\"", 1658, 1);
#line 54 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1630, Url.Action("Cafey","Admin"), 1630, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1659, 39, true);
                WriteLiteral(">Cafey & Restaurent</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1698, "\"", 1737, 1);
#line 55 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1705, Url.Action("Bussiness","Admin"), 1705, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1738, 30, true);
                WriteLiteral(">Bussines</a></li>\n     <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1768, "\"", 1805, 1);
#line 56 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1775, Url.Action("Gallery","Admin"), 1775, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1806, 28, true);
                WriteLiteral(">Gallery</a></li>\n    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1834, "\"", 1876, 1);
#line 57 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
WriteAttributeValue("", 1841, Url.Action("Anouncements","Admin"), 1841, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1877, 220, true);
                WriteLiteral(">Anouncements</a></li>\n    <li><a class=\"waves-effect\" href=\"#!\">Logout</a></li>\n  </ul>\n  <a href=\"#\" data-target=\"slide-out\" class=\"sidenav-trigger\"><i class=\"material-icons\">menu</i></a>\n  <div class=\"container\">\n    ");
                EndContext();
                BeginContext(2098, 12, false);
#line 62 "/home/munnim/Desktop/count1/Views/Shared/_AdminLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2110, 23, true);
                WriteLiteral("\n\n  </div>\n\n    \n   \n\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 9, true);
            WriteLiteral("\n</html>\n");
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
