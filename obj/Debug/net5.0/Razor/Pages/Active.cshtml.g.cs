#pragma checksum "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0edc4bfc3178f2037088154e38bbebe45b04aab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Adm4379Example.Pages.Pages_Active), @"mvc.1.0.razor-page", @"/Pages/Active.cshtml")]
namespace Adm4379Example.Pages
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
#line 1 "C:\Users\Administrator\Documents\CrowdConsult\Pages\_ViewImports.cshtml"
using Adm4379Example;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0edc4bfc3178f2037088154e38bbebe45b04aab8", @"/Pages/Active.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4db0fbb39e7a329e0f45057c6b09661aeb7cf5a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Active : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
  
    ViewData["Title"] = "Active business cases";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0edc4bfc3178f2037088154e38bbebe45b04aab83222", async() => {
                WriteLiteral("\r\n        <title>Active Business Cases</title>\r\n        <script src=\"js/site.js\"></script>\r\n    ");
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
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0edc4bfc3178f2037088154e38bbebe45b04aab84296", async() => {
                WriteLiteral("\r\n        <h1><span>Active Business Cases</span></h1>\r\n        <div class=\"zone flex-wrapper\">\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
             foreach (var bcase in Model.Cases)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"/Case\">\r\n                    <div class=\"box zone\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col75percent img-wrapper\"><img");
                BeginWriteAttribute("src", " src=\"", 572, "\"", 589, 1);
#nullable restore
#line 21 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
WriteAttributeValue("", 578, bcase.logo, 578, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><h6>");
#nullable restore
#line 21 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
                                                                                        Write(bcase.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6></div>\r\n                            <div class=\"col25percent info\">\r\n                                <div>Responses: ");
#nullable restore
#line 23 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
                                           Write(bcase.num_responses);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                <div");
                BeginWriteAttribute("id", " id=\"", 793, "\"", 810, 1);
#nullable restore
#line 24 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
WriteAttributeValue("", 798, bcase.index, 798, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                <div>Bounty (USD): ");
#nullable restore
#line 25 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
                                              Write(bcase.bounty);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 30 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        \r\n");
#nullable restore
#line 33 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
         foreach (var bcase in Model.Cases) {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script type=\"text/javascript\">\r\n                document.getElementById(");
#nullable restore
#line 35 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
                                   Write(bcase.index);

#line default
#line hidden
#nullable disable
                WriteLiteral(").innerHTML = timeElapsed(");
#nullable restore
#line 35 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
                                                                         Write(bcase.datetime);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n            </script>\r\n");
#nullable restore
#line 37 "C:\Users\Administrator\Documents\CrowdConsult\Pages\Active.cshtml"
        } 

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActiveModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActiveModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActiveModel>)PageContext?.ViewData;
        public ActiveModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591