#pragma checksum "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2661e028e323133fd2e96110799faa231dc73d0"
// <auto-generated/>
#pragma warning disable 1591
namespace ActuatorsTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using ActuatorsTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using ActuatorsTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudContainer>(8);
                __builder2.AddAttribute(9, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 11 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\Shared\MainLayout.razor"
                            MaxWidth.ExtraLarge

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line (12,10)-(12,14) 26 "C:\Users\mchlc\Source\Repos\Button-Pusher-POC-1\ActuatorsTest\Shared\MainLayout.razor"
__builder3.AddContent(11, Body);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
