#pragma checksum "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ed0429783ff28b0f6f83c2a20021ff19ff9043"
// <auto-generated/>
#pragma warning disable 1591
namespace Parcial_II.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Parcial_II;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\_Imports.razor"
using Parcial_II.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
using Parcial_II.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoRecursos")]
    public partial class ListadoRecursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado de Recursos</h3>\r\n\r\n");
#nullable restore
#line 7 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
 if (recursos == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Nombre</th>\r\n                <th>IdUsuario</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
             foreach (var recurso in recursos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
                         recurso.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
                         recurso.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
                         recurso.IdUsuario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 29 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 32 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\ListadoRecursos.razor"
       
    private Recursos[] recursos;

    protected override async Task OnInitializedAsync()
    {
        recursos = RecursosService.GetRecursos();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursosService RecursosService { get; set; }
    }
}
#pragma warning restore 1591