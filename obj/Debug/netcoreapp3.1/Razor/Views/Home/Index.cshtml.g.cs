#pragma checksum "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2e1d53dcef60e44fe73aa28b975c298dea764ff8188c0d5c8ed99d34d3304a40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\_ViewImports.cshtml"
using DotNetCoreCalendar

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\_ViewImports.cshtml"
using DotNetCoreCalendar.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2e1d53dcef60e44fe73aa28b975c298dea764ff8188c0d5c8ed99d34d3304a40", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"729fba6dc47b33be5e169314e3774ef9d05089691587f0f5608e30f3b710ecd3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<script>

      document.addEventListener('DOMContentLoaded', function() {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: ");
            Write(
#nullable restore
#line 11 "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\Home\Index.cshtml"
                     Html.Raw(ViewData["Events"])

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(",\n            resources: ");
            Write(
#nullable restore
#line 12 "C:\Users\Admin\Downloads\NetCoreCalendar-master\Views\Home\Index.cshtml"
                        Html.Raw(ViewData["Resources"])

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@",
            headerToolbar: {
                left: 'today prev,next',
                center: 'title',
                right: 'timeGridWeek,dayGridMonth,listMonth'
            },
        });
        calendar.render();
      });

</script>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome To Our Calendar App!</h1>
    <a href=""/MyCalendar"">View My Calendar</a>
</div>

<div class=""row"">
    <div class=""col-md-6"">
        <a href=""/Event""><h3>Events</h3></a>
    </div>
    <div class=""col-md-6"">
        <a href=""/Location""><h3>Locations</h3></a>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
