// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace codeforthecarolinas.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using codeforthecarolinas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using codeforthecarolinas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/ewmcelvaney/Desktop/Code for the Carolinas/codeforthecarolinas/codeforthecarolinas/codeforthecarolinas/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
