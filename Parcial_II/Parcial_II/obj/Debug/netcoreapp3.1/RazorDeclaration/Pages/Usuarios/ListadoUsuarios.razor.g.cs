#pragma checksum "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\ListadoUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8339baafb2ab3814b193f003b9d4abb2fe26ef5c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Parcial_II.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Parcial_II;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Parcial_II.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\ListadoUsuarios.razor"
using Parcial_II.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoUsuarios")]
    public partial class ListadoUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\ListadoUsuarios.razor"
       
    private List<Usuarios> usuarios;

    protected override async Task OnInitializedAsync()
    {
        usuarios = await UsuariosService.GetAll();
    }
    protected void Editar(int id)
    {
        navigation.NavigateTo("usuarios/editar/" + id);
    }
    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el usuario?");
        if (confirmed)
        {
            await UsuariosService.Remove(id);
            usuarios = await UsuariosService.GetAll();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuariosService UsuariosService { get; set; }
    }
}
#pragma warning restore 1591
