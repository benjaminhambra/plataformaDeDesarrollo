#pragma checksum "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e46c18eadadd35b480d46c377332cd665e847e"
// <auto-generated/>
#pragma warning disable 1591
namespace Parcial_II.Pages.Recursos
{
    #line hidden
    using System;
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
#line 2 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
using Parcial_II.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoRecursos")]
    public partial class ListadoRecursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado de Recursos</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                              ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
 if (recursos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Nombre</th>\r\n                <th>Usuario</th>\r\n                <th>Acciones</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 28 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
             foreach (var recurso in recursos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                         recurso.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                         recurso.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 33 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                         recurso.Usuario.Usuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                                                      ()=>Editar(recurso.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
                                                      ()=>Borrar(recurso.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Borrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 39 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 42 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\ListadoRecursos.razor"
       
    private List<Recursos> recursos;

    protected override async Task OnInitializedAsync()
    {
        recursos = await RecursosService.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("recursos/editar/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el recurso?");
        if (confirmed)
        {
            await RecursosService.Remove(id);
            recursos = await RecursosService.GetAll();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursosService RecursosService { get; set; }
    }
}
#pragma warning restore 1591
