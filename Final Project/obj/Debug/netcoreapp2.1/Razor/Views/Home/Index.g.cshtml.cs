#pragma checksum "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ca83cbf22430b6cfd6c59dda0179b4350237c6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ca83cbf22430b6cfd6c59dda0179b4350237c6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 711, true);
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
            <input id=""SearchBar"" class=""col-6"" autocomplete=""on"" type=""search"" name=""search"" placeholder=""&#xF002 Find a location""/>
        </div>
    </div>
    <div class=""row"" id=""map""></div>

</div>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCDQe2Nov8eYcEOSJpHSxo5CIyC9BvMTgk&libraries=places&callback=initMap""
        async defer></script>

<script>
    var LocList = ");
            EndContext();
            BeginContext(763, 44, false);
#line 23 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Home\Index.cshtml"
             Write(Html.Raw(Json.Serialize(Model.LocationList)));

#line default
#line hidden
            EndContext();
            BeginContext(807, 16, true);
            WriteLiteral(";\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
