#pragma checksum "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c92c5bf2134d15d59a8a72e307ed66d901acf0e"
// <auto-generated/>
#pragma warning disable 1591
namespace Parcial_II.Pages.Recursos
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
#line 2 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
using Parcial_II.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recursos/editar/{id:int}")]
    public partial class EditarRecursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
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
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Nombre\r\n        </label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-10");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
                                    Modelo.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Nombre = __value, Modelo.Nombre))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.Parcial_II.Pages.Recursos.EditarRecursos.TypeInference.CreateInputSelect_0(__builder2, 26, 27, 
#nullable restore
#line 18 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
                                  UsuarioId

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UsuarioId = __value, UsuarioId)), 29, () => UsuarioId, 30, (__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.AddMarkupContent(32, "<option value=\"0\">Elija un Usuario</option>\r\n");
#nullable restore
#line 20 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
             foreach (var item in usuarios)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(33, "                ");
                    __builder3.OpenElement(34, "option");
                    __builder3.AddAttribute(35, "value", 
#nullable restore
#line 22 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(36, 
#nullable restore
#line 22 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
                                          item.Usuario

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n");
#nullable restore
#line 23 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(38, "        ");
                }
                );
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.AddMarkupContent(41, "<button type=\"submit\">Guardar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "E:\Users\Benja\Source\Repos\plataformaDeDesarrollo\Parcial_II\Parcial_II\Pages\Recursos\EditarRecursos.razor"
       
    [Parameter]
    public int Id { get; set; }
    public Recursos Modelo { get; set; } = new Recursos();

    public string UsuarioId { get; set; }
    private List<Usuarios> usuarios;

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            Modelo = await RecursosService.GetById(Id);
            UsuarioId = Modelo.UsuarioId.ToString();
        }
        else
        {
            Modelo = new Recursos();
        }
        usuarios = await RecursosService.GetUsuarios();
    }

    private async void Guardar()
    {
        Modelo.UsuarioId = int.Parse(UsuarioId);
        await RecursosService.Save(Modelo);
        navigation.NavigateTo("ListadoRecursos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursosService RecursosService { get; set; }
    }
}
namespace __Blazor.Parcial_II.Pages.Recursos.EditarRecursos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591