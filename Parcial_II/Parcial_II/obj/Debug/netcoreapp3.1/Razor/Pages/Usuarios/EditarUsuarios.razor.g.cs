#pragma checksum "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebb8295718fb5aece1255576efac8003f0eff4ea"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
using Parcial_II.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios/editar/{id:int}")]
    public partial class EditarUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
                            Modelo.Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Usuario = __value, Modelo.Usuario))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.Usuario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
                            Modelo.Clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Clave = __value, Modelo.Clave))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.Clave));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n    ");
                __builder2.AddMarkupContent(19, "<button type=\"submit\">Guardar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Usuarios\EditarUsuarios.razor"
       
    [Parameter]
    public int Id { get; set; }
    public Usuarios Modelo { get; set; } = new Usuarios();
    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            Modelo = await UsuariosService.GetById(Id);
        }
        else
        {
            Modelo = new Usuarios();
        }
    }

    private async void Guardar()
    {
        await UsuariosService.Save(Modelo);
        navigation.NavigateTo("ListadoUsuarios");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuariosService UsuariosService { get; set; }
    }
}
#pragma warning restore 1591
