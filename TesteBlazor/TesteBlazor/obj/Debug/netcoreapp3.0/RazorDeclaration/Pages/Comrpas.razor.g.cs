#pragma checksum "C:\Users\alanbarros\source\repos\TesteBlazor\TesteBlazor\Pages\Comrpas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916f0e444ad1041c6a4030df11db51e17c0fd378"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TesteBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using TesteBlazor.Shared;
    using TesteBlazor.Data.Services;
    using TesteBlazor.Data.Models;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/compras")]
    public class Comrpas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 23 "C:\Users\alanbarros\source\repos\TesteBlazor\TesteBlazor\Pages\Comrpas.razor"
           
    IEnumerable<Compra> compras;

    protected override async Task OnInitAsync()
    {
        compras = await compraService.GetCompras();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompraService compraService { get; set; }
    }
}
#pragma warning restore 1591