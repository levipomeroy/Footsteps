#pragma checksum "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7a39ae004b672533cfe3dabd32a5fee6f535024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_AdminContact), @"mvc.1.0.view", @"/Views/Contact/AdminContact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/AdminContact.cshtml", typeof(AspNetCore.Views_Contact_AdminContact))]
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
#line 1 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
using Final_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7a39ae004b672533cfe3dabd32a5fee6f535024", @"/Views/Contact/AdminContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_AdminContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/AdminPageStyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(60, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c10d03f1d543179f461758f799865b", async() => {
                BeginContext(66, 34, true);
                WriteLiteral("\r\n    <title>Contact</title>\r\n    ");
                EndContext();
                BeginContext(100, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b22290c08b72476cb5e7122b2f23a77b", async() => {
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
                BeginContext(161, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(170, 320, true);
            WriteLiteral(@"
<div id=""content"" class=""container grid"">
    <div id=""ActionBar"">
        <div class=""row"">
            <button type=""button"" id=""sidebarCollapse"" class=""navbar-btn"">
                <span></span>
                <span></span>
                <span></span>
            </button>
        </div>
    </div>

");
            EndContext();
            BeginContext(512, 362, true);
            WriteLiteral(@"    <div class=""row container"">
        <h1>User Messages</h1>
        <table id=""MesssagesTable"" class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Type</th>
                    <th>Message</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 32 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
                    foreach(var message in Model)
                   {

#line default
#line hidden
            BeginContext(947, 60, true);
            WriteLiteral("                       <tr>\r\n                           <td>");
            EndContext();
            BeginContext(1008, 16, false);
#line 35 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
                          Write(message.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 38, true);
            WriteLiteral("</td>\r\n                           <td>");
            EndContext();
            BeginContext(1063, 12, false);
#line 36 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
                          Write(message.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 38, true);
            WriteLiteral("</td>\r\n                           <td>");
            EndContext();
            BeginContext(1114, 15, false);
#line 37 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
                          Write(message.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 37, true);
            WriteLiteral("</td>\r\n                       </tr>\r\n");
            EndContext();
#line 39 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Contact\AdminContact.cshtml"
                   }

#line default
#line hidden
            BeginContext(1188, 60, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
