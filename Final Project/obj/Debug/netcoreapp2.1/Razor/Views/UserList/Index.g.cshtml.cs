#pragma checksum "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5706c1bde0628e904a6a2bdb4fb4e61dc473e145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserList_Index), @"mvc.1.0.view", @"/Views/UserList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserList/Index.cshtml", typeof(AspNetCore.Views_UserList_Index))]
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
#line 1 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
using Final_Project.Models;

#line default
#line hidden
#line 2 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
using Final_Project.BusinessObjects;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5706c1bde0628e904a6a2bdb4fb4e61dc473e145", @"/Views/UserList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Views/_ViewImports.cshtml")]
    public class Views_UserList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/UserListStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(95, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(99, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c992babfd6a4fda8e415bbc0acec4d0", async() => {
                BeginContext(105, 32, true);
                WriteLiteral("\r\n    <title>Lists</title>\r\n    ");
                EndContext();
                BeginContext(137, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "576871f69b91438fb373c44d59966565", async() => {
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
                BeginContext(196, 2, true);
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
            BeginContext(205, 711, true);
            WriteLiteral(@"

<!-- Page Content -->
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
    <div class=""row"" id=""ListContent"">
        <div class=""col-4"">
            <div class=""card"">
                <div class=""card-header"">Lists 
                <button id=""AddListBtn"" type=""button"" onclick=""AddList()"" class=""btn btn-default""><i class=""fas fa-plus""></i></button>
                </div>
                <div id=""ListOfLists"" class=""card-body"">
");
            EndContext();
#line 29 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
                     for (int i = 0; i < Model.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(1001, 61, true);
            WriteLiteral("                        <div>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1062, "\"", 1101, 3);
            WriteAttributeValue("", 1072, "ListClicked([", 1072, 13, true);
#line 32 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
WriteAttributeValue("", 1085, Model[i].ID, 1085, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1099, "])", 1099, 2, true);
            EndWriteAttribute();
            BeginContext(1102, 10, true);
            WriteLiteral(" href=\"#\">");
            EndContext();
            BeginContext(1113, 13, false);
#line 32 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
                                                                           Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 38, true);
            WriteLiteral("</a>\r\n                        </div>\r\n");
            EndContext();
#line 34 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1187, 752, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col-8"">
            <div class=""card"">
                <div id=""ItemHeader"" class=""card-header""> List name goes here
                    <button id=""AddListItemBtn"" type=""button"" class=""btn btn-default""><i class=""fas fa-plus""></i></button>
                </div>
                <div id=""ItemBody"" class=""card-body"">

                </div>
            </div>
        </div>
    </div>
</div>

<script>

    function AddList() {
        //Get new list name
        var Name = prompt(""Enter the list name"", ""i.e. Bucket List"");
        //Store new list name in DB via service call
        if (Name != null) {
            $.ajax({
                url: '");
            EndContext();
            BeginContext(1940, 33, false);
#line 59 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
                 Write(Url.Action("AddList", "UserList"));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 448, true);
            WriteLiteral(@"',
                type: 'POST',
                data: { Name: Name },
            });
            //update list of lists with new list name 
            document.getElementById(""ListOfLists"").innerHTML += ""<div><a href='#'>"" + Name + ""</a></div>""
        }
    }

    function ListClicked(ID) {
        if (ID != null) {
            //document.getElementById(""ItemHeader"").innerHTML = ID;

            $.ajax({
                url: '");
            EndContext();
            BeginContext(2422, 45, false);
#line 73 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\UserList\Index.cshtml"
                 Write(Url.Action("GetListItemsForList", "UserList"));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 608, true);
            WriteLiteral(@"',
                type: 'POST',
                data: { ID: ID },
                //contenttype: 'json',
                success: function (data) {
                    //alert(data);
                    var objList = JSON.parse(data);
                    document.getElementById(""ItemBody"").innerHTML = '';
                    for (var i = 0; i < objList.length; i++) {
                        //alert(objList[i])
                        document.getElementById(""ItemBody"").innerHTML += objList[i].item;

                    }
                }
            });
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
