#pragma checksum "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2fdfcf6556434c3e0a91a6dfa19df8e6bc0a4a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fdfcf6556434c3e0a91a6dfa19df8e6bc0a4a1", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/DashboardStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/MDB/js/mdb.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35cd4e31032d42459042c276f9cc2b3b", async() => {
                BeginContext(8, 36, true);
                WriteLiteral("\r\n    <title>Dashboard</title>\r\n    ");
                EndContext();
                BeginContext(44, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edaa9e42c1d142b983d061e25eee90a5", async() => {
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
                BeginContext(104, 2, true);
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
            BeginContext(113, 322, true);
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
            BeginContext(452, 128, true);
            WriteLiteral("    <div class=\"container\">\r\n        <h2>Your Statistics</h2>\r\n    </div>\r\n    <div class=\"row container\" id=\"DashboardStats\">\r\n");
            EndContext();
            BeginContext(625, 223, true);
            WriteLiteral("        <div class=\"col-3\">\r\n            <div id=\"CountriesVisitedChart\">\r\n                <label class=\"control-label\">Countries Visited</label>\r\n                <div id=\"bar\"></div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(883, 331, true);
            WriteLiteral(@"        <div class=""col-5"">
            <div id=""TripsOverTime"">
                <label class=""control-label"">Visited This Year</label>
                <div class=""wrapperForCentering"">
                    <canvas id=""lineChart"" height=""180"" width=""400""></canvas>
                </div>
            </div>
        </div>

");
            EndContext();
            BeginContext(1252, 350, true);
            WriteLiteral(@"        <div class=""col-4"">
            <div id=""CategoriesChart"">
                <label class=""control-label"">Categories</label>
                <div class=""wrapperForCentering"">
                    <canvas id=""doughnutChart""></canvas>
                </div>
            </div>
        </div>

    </div>
    <div class=""row container"">
");
            EndContext();
            BeginContext(1653, 99, true);
            WriteLiteral("        <div class=\"col-12\">\r\n            <h2>Leaderboards </h2>\r\n            <div class=\"row\">\r\n\r\n");
            EndContext();
            BeginContext(1800, 251, true);
            WriteLiteral("                <div class=\"col-4\">\r\n                    <div id=\"MostPinsLeaderboard\" class=\"card\">\r\n                        <div class=\"card-header\">Most Locations</div>\r\n                        <div id=\"MostPinsLeaderboardBody\" class=\"card-body\">\r\n");
            EndContext();
            BeginContext(2129, 86, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
            EndContext();
            BeginContext(2263, 261, true);
            WriteLiteral(@"                <div class=""col-4"">
                    <div id=""MostCountriesLeaderboard"" class=""card"">
                        <div class=""card-header"">Most Countries</div>
                        <div id=""MostCountriesLeaderboardBody"" class=""card-body"">
");
            EndContext();
            BeginContext(2602, 86, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
            EndContext();
            BeginContext(2743, 793, true);
            WriteLiteral(@"                <div class=""col-4"">
                    <div id=""MostLocationsMonthLeaderboard"" class=""card"">
                        <div class=""card-header"">Most Locations This Month</div>
                        <div class=""card-body"">

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
<script>
    function StartUpFunc() {
        const num_countries_in_world = 195;

        //Set up countries visited bar
        var bar = new RadialProgress(document.getElementById(""bar""), { colorFg: ""#0080FF"", thick: 10, fixedTextSize: 0.25, colorText: ""#000000"" });
        bar.setIndeterminate(false);

        //Call service to get country count for user
        $.ajax({
            url: '");
            EndContext();
            BeginContext(3537, 42, false);
#line 102 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Dashboard\Index.cshtml"
             Write(Url.Action("GetCountryCount", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(3579, 5855, true);
            WriteLiteral(@"',
            type: 'POST',
            data: { },
            success: function (data) {
                bar.setValue(data / num_countries_in_world);
            }
        });

        NumberOfLocaionsLeaderboard(); //populate location number leaderboard
        NumberOfCountriesLeaderboard(); //populate country number leaderboard
        TripsOverTimeGraph(); //populate trip over time graph
        CategoryChart(); //populate category doughnut chart
    }
    window.onload = StartUpFunc;

    //stuff for circular progress bar
    window.rp_requestAnimationFrame = window.requestAnimationFrame || window.webkitRequestAnimationFrame || window.mozRequestAnimationFrame || window.msRequestAnimationFrame || (function (callback, element) { setTimeout(callback, 1000 / 60); });
    function RadialProgress(container, cfg) {
        container.innerHTML = """";
        var nc = document.createElement(""div"");
        nc.style.width = ""10em""; nc.style.height = ""10em"";
        nc.style.position = ""relati");
            WriteLiteral(@"ve"";
        container.appendChild(nc);
        container = nc;
        if (!cfg) cfg = {};
        this.colorBg = cfg.colorBg == undefined ? ""#404040"" : cfg.colorBg;
        this.colorFg = cfg.colorFg == undefined ? ""#007FFF"" : cfg.colorFg;
        this.colorText = cfg.colorText == undefined ? ""#FFFFFF"" : cfg.colorText;
        this.indeterminate = cfg.indeterminate == undefined ? false : cfg.indeterminate;
        this.round = cfg.round == undefined ? false : cfg.round;
        this.thick = cfg.thick == undefined ? 2 : cfg.thick;
        this.progress = cfg.progress == undefined ? 0 : cfg.progress;
        this.noAnimations = cfg.noAnimations == undefined ? 0 : cfg.noAnimations;
        this.fixedTextSize = cfg.fixedTextSize == undefined ? false : cfg.fixedTextSize;
        this.animationSpeed = cfg.animationSpeed == undefined ? 1 : cfg.animationSpeed > 0 ? cfg.animationSpeed : 1;
        this.noPercentage = cfg.noPercentage == undefined ? false : cfg.noPercentage;
        this.spin = cfg.spi");
            WriteLiteral(@"n == undefined ? false : cfg.spin;
        if (cfg.noInitAnimation) this.aniP = this.progress; else this.aniP = 0;
        var c = document.createElement(""canvas"");
        c.style.position = ""absolute""; c.style.top = ""0""; c.style.left = ""0""; c.style.width = ""100%""; c.style.height = ""100%""; c.className = ""rp_canvas"";
        container.appendChild(c);
        this.canvas = c;
        var tcc = document.createElement(""div"");
        tcc.style.position = ""absolute""; tcc.style.display = ""table""; tcc.style.width = ""100%""; tcc.style.height = ""100%"";
        var tc = document.createElement(""div"");
        tc.style.display = ""table-cell""; tc.style.verticalAlign = ""middle"";
        var t = document.createElement(""div"");
        t.style.color = this.colorText; t.style.textAlign = ""center""; t.style.overflow = ""visible""; t.style.whiteSpace = ""nowrap""; t.className = ""rp_text"";
        tc.appendChild(t);
        tcc.appendChild(tc);
        container.appendChild(tcc);
        this.text = t;
        this.pre");
            WriteLiteral(@"vW = 0; this.prevH = 0; this.prevP = 0; this.indetA = 0; this.indetB = 0.2; this.rot = 0;
        this.draw = function (f) {
            if (!(f == true)) rp_requestAnimationFrame(this.draw);
            var c = this.canvas;
            var dp = window.devicePixelRatio || 1;
            c.width = c.clientWidth * dp; c.height = c.clientHeight * dp;
            if (!(f == true) && !this.spin && !this.indeterminate && (Math.abs(this.prevP - this.progress) < 1 && this.prevW == c.width && this.prevH == c.height)) return;
            var centerX = c.width / 2, centerY = c.height / 2, bw = (c.clientWidth / 100.0), radius = c.height / 2 - (this.thick * bw * dp) / 2, bw = (c.clientWidth / 100.0);
            this.text.style.fontSize = (this.fixedTextSize ? (c.clientWidth * this.fixedTextSize) : (c.clientWidth * 0.26 - this.thick)) + ""px"";
            if (this.noAnimations) this.aniP = this.progress; else { var aniF = Math.pow(0.93, this.animationSpeed); this.aniP = this.aniP * aniF + this.progress * (1 - aniF");
            WriteLiteral(@"); }
            c = c.getContext(""2d"");
            c.beginPath();
            c.strokeStyle = this.colorBg;
            c.lineWidth = this.thick * bw * dp;
            c.arc(centerX, centerY, radius, -Math.PI / 2, 2 * Math.PI);
            c.stroke();
            c.beginPath();
            c.strokeStyle = this.colorFg;
            c.lineWidth = this.thick * bw * dp;
            if (this.round) c.lineCap = ""round"";
            if (this.indeterminate) {
                this.indetA = (this.indetA + 0.07 * this.animationSpeed) % (2 * Math.PI); this.indetB = (this.indetB + 0.14 * this.animationSpeed) % (2 * Math.PI);
                c.arc(centerX, centerY, radius, this.indetA, this.indetB);
                if (!this.noPercentage) this.text.innerHTML = """";
            } else {
                if (this.spin && !this.noAnimations) this.rot = (this.rot + 0.07 * this.animationSpeed) % (2 * Math.PI)
                c.arc(centerX, centerY, radius, this.rot - Math.PI / 2, this.rot + this.aniP * (2 * Mat");
            WriteLiteral(@"h.PI) - Math.PI / 2);
                if (!this.noPercentage) this.text.innerHTML = Math.round(100 * this.aniP) + "" %"";
            }
            c.stroke();
            this.prevW = c.width; this.prevH = c.height; this.prevP = this.aniP;
        }.bind(this);
        this.draw();
    }
    RadialProgress.prototype = {
        constructor: RadialProgress,
        setValue: function (p) { this.progress = p < 0 ? 0 : p > 1 ? 1 : p; },
        setIndeterminate: function (i) { this.indeterminate = i; },
        setText: function (t) { this.text.innerHTML = t; }
    }


    //Call service to get pin leaderboard info and populate it
    function NumberOfLocaionsLeaderboard() {
         $.ajax({
            url: '");
            EndContext();
            BeginContext(9435, 49, false);
#line 199 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Dashboard\Index.cshtml"
             Write(Url.Action("GetMostPinsLeaderboard", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(9484, 526, true);
            WriteLiteral(@"',
            type: 'POST',
            data: { },
             success: function (data) {
                 var content = ""<ul>"";
                 for (var i = 0; i < 5; i++) {
                         content += ""<li>"" + data[i] + ""</li>"";
                 }
                 content += ""</ul>"";
                 document.getElementById(""MostPinsLeaderboardBody"").innerHTML = content;
            }
        });
    }

    function NumberOfCountriesLeaderboard() {
                 $.ajax({
            url: '");
            EndContext();
            BeginContext(10011, 54, false);
#line 215 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Dashboard\Index.cshtml"
             Write(Url.Action("GetMostCountriesLeaderboard", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(10065, 837, true);
            WriteLiteral(@"',
            type: 'POST',
            data: { },
             success: function (data) {
                 var content = ""<ul>"";
                 for (var i = 0; i < 5; i++) {
                         content += ""<li>"" + data[i] + ""</li>"";
                 }
                 content += ""</ul>"";
                 document.getElementById(""MostCountriesLeaderboardBody"").innerHTML = content;
            }
        });
    }


    //Get data and populate trips over time chart
    function TripsOverTimeGraph() {
        //get data
        var months = [];
        var monthCount = {
            ""January"": 0, ""February"": 0, ""March"": 0, ""April"": 0,
            ""May"": 0, ""June"": 0, ""July"": 0, ""August"": 0, ""September"": 0, ""October"": 0,
            ""November"": 0, ""December"": 0};
        $.ajax({
            url: '");
            EndContext();
            BeginContext(10903, 42, false);
#line 239 "C:\Users\levip_000\Documents\GitHub\Footsteps\Final Project\Views\Dashboard\Index.cshtml"
             Write(Url.Action("GetDatesOfTrips", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(10945, 3921, true);
            WriteLiteral(@"',
            type: 'POST',
            data: { },
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var arr = data[i].split(""-"");
                    months.push(arr[1]);
                }
                for (var i = 0; i < months.length; i++) {
                    if (months[i] == 1) {
                        monthCount[""January""]++;
                    }
                    else if (months[i] == 2) {
                        monthCount[""February""]++;
                    }
                    else if (months[i] == 3) {
                        monthCount[""March""]++;
                    }
                    else if (months[i] == 4) {
                        monthCount[""April""]++;
                    }
                    else if (months[i] == 5) {
                        monthCount[""May""]++;
                    }
                    else if (months[i] == 6) {
                        monthCount[""June""]++;
             ");
            WriteLiteral(@"       }
                    else if (months[i] == 7) {
                        monthCount[""July""]++;
                    }
                    else if (months[i] == 8) {
                        monthCount[""August""]++;
                    }
                    else if (months[i] == 9) {
                        monthCount[""September""]++;
                    }
                    else if (months[i] == 10) {
                        monthCount[""October""]++;
                    }
                    else if (months[i] == 11) {
                        monthCount[""November""]++;
                    }
                    else if (months[i] == 12) {
                        monthCount[""December""]++;
                    }
                }

                //alert(monthCount[""January""]);
                var ctxL = document.getElementById(""lineChart"").getContext('2d');
                var myLineChart = new Chart(ctxL, {
                    type: 'line',
                    data: {
               ");
            WriteLiteral(@"         labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""],
                        datasets: [{
                            label: ""Places per month"",
                            data: [monthCount[""January""], monthCount[""February""], monthCount[""March""],
                            monthCount[""April""], monthCount[""May""], monthCount[""June""],
                            monthCount[""July""], monthCount[""August""], monthCount[""September""],
                            monthCount[""October""], monthCount[""November""], monthCount[""December""]],
                            backgroundColor: [
                                '#b3d9ff',
                            ],
                            borderColor: [
                                '#0080FF',
                            ],
                            borderWidth: 2
                        }]
                    },
                    options: {
                        re");
            WriteLiteral(@"sponsive: false
                    }
                });
            }
        });
    }


    //category chart func
    function CategoryChart() {
        //Set up for categories doughnut chart
        var ctxD = document.getElementById(""doughnutChart"").getContext('2d');
        var myLineChart = new Chart(ctxD, {
            type: 'doughnut',
            data: {
                labels: [""Visited"", ""Want to go"", ""Lived"", ""Bucket list""],
                datasets: [{
                    data: [250, 50, 10, 40],
                    backgroundColor: [""#F7464A"", ""#46BFBD"", ""#FDB45C"", ""#949FB1""],
                    hoverBackgroundColor: [""#FF5A5E"", ""#5AD3D1"", ""#FFC870"", ""#A8B3C5""]
                }]
            },
            options: {
                responsive: true
            }
        });
    }
</script>

");
            EndContext();
            BeginContext(14866, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6791657aca5747699b09554196699832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
