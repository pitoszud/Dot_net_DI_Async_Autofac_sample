#pragma checksum "E:\.Net\DI_study\DependencyInjection\About\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a31ded5638b09b05b87b6c13e0f98dfc846762"
// <auto-generated/>
#pragma warning disable 1591
namespace DependencyInjection.About
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using DependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\.Net\DI_study\DependencyInjection\_Imports.razor"
using DependencyInjection.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>About</h3>");
#nullable restore
#line 6 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
 if (AboutList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading About List...</em></p>");
#nullable restore
#line 9 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Monday</th>\r\n                <th>Tuesday</th>\r\n                <th>Wednsday</th>\r\n                <th>Thursday</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
             foreach (var aboutItem in AboutList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 25 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
                         aboutItem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
                         aboutItem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
                         aboutItem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
                         aboutItem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "E:\.Net\DI_study\DependencyInjection\About\About.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
