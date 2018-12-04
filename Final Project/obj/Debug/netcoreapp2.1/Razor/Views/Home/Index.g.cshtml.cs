#pragma checksum "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea57ff931489b0b51e54c811351036be894030d"
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
#line 1 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
using Final_Project.Models;

#line default
#line hidden
#line 3 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea57ff931489b0b51e54c811351036be894030d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/MapPageScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2707d6d8d0244a81bfaf6e6ec87c7b4f", async() => {
                BeginContext(133, 26, true);
                WriteLiteral("\r\n    <title>Map</title>\r\n");
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
            BeginContext(166, 632, true);
            WriteLiteral(@"
<!-- Page Content -->
<div id=""content"" class=""grid"">
    <div id=""ActionBarMap"">
        <div class=""row"">
            <button type=""button"" id=""sidebarCollapse"" class=""navbar-btn"">
                <span></span>
                <span></span>
                <span></span>
            </button>
            <input id=""SearchBar"" class=""col-6"" autocomplete=""on"" type=""search"" name=""search"" placeholder=""&#xF002 Find a location"" />
            <a href=""../LocationForm"" id=""AddLocationBTN"" name=""AddLocationBTN""> <i class=""fas fa-plus""></i></a>
        </div>
    </div>
    <div class=""row"" id=""map""></div>

</div>
");
            EndContext();
            BeginContext(962, 7, true);
            WriteLiteral("<script");
            EndContext();
            BeginWriteAttribute("src", " \r\n        src=\"", 969, "\"", 1088, 3);
            WriteAttributeValue("", 985, "https://maps.googleapis.com/maps/api/js?key=", 985, 44, true);
#line 28 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 1029, config["GoogleAPIKey"], 1029, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 1054, "&libraries=places&callback=initMap", 1054, 34, true);
            EndWriteAttribute();
            BeginContext(1089, 61, true);
            WriteLiteral("\r\n    async defer>\r\n</script>\r\n\r\n<script>\r\n    var LocList = ");
            EndContext();
            BeginContext(1151, 44, false);
#line 33 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
             Write(Html.Raw(Json.Serialize(Model.LocationList)));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 136, true);
            WriteLiteral(";\r\n\r\n    function RemoveMarkerFromMap(id) {\r\n        $.ajax({\r\n            //url: \'/HomeController/Remove_Location\',\r\n            url: \'");
            EndContext();
            BeginContext(1332, 37, false);
#line 38 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
             Write(Url.Action("Remove_Location", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 230, true);
            WriteLiteral("\', //either url works\r\n            type: \'POST\',\r\n            data: { lat: MarkerList[id].getPosition().lat(), lon: MarkerList[id].getPosition().lng() },\r\n        });\r\n\r\n        MarkerList[id].setMap(null);\r\n    }\r\n</script>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1599, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b13b1c4c1f7a492d81925438fe4ddb79", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public IConfiguration config { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
