#pragma checksum "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5968d093b542229f87ff345508dfaa32a078bb9b"
// <auto-generated/>
#pragma warning disable 1591
namespace segundoexamenparcial_v2.Pages.PeliculaActorRol
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using segundoexamenparcial_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/_Imports.razor"
using segundoexamenparcial_v2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
using segundoexamenparcial_v2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
using segundoexamenparcial_v2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EliminarPeliculaActorRol/{Id}")]
    public partial class EliminarPeliculaActorRol : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Eliminar pelicula-actor-rol</h3>\n<hr>\n");
            __builder.AddMarkupContent(1, "<h3>¿Estas seguro que desas Eliminar? </h3>\n\n\n ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "fieldset");
                __builder2.AddAttribute(10, "disabled", "true");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"PeliculaId\" class=\"control-label\">Pelicula Id</label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EliminarPeliculaActorRol.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "PeliculaId", 16, "form-control", 17, 
#nullable restore
#line 22 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                               obj.PeliculaId

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.PeliculaId = __value, obj.PeliculaId)), 19, () => obj.PeliculaId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"ActorId\" class=\"control-label\">Actor Id </label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EliminarPeliculaActorRol.TypeInference.CreateInputNumber_1(__builder2, 24, 25, "ActorId", 26, "form-control", 27, 
#nullable restore
#line 26 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                            obj.ActorId

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.ActorId = __value, obj.ActorId)), 29, () => obj.ActorId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"RolId\" class=\"control-label\">Rol Id </label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EliminarPeliculaActorRol.TypeInference.CreateInputNumber_2(__builder2, 34, 35, "RolId", 36, "form-control", 37, 
#nullable restore
#line 30 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                          obj.RolId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.RolId = __value, obj.RolId)), 39, () => obj.RolId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"Personaje\" class=\"control-label\">Personaje </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "Personaje");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                            obj.Personaje

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Personaje = __value, obj.Personaje))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Personaje));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n            ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "<label for=\"Descripcion\" class=\"control-label\">Descripción </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "id", "Descripcion");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                              obj.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Descripcion = __value, obj.Descripcion))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenElement(61, "button");
                __builder2.AddAttribute(62, "type", "submit");
                __builder2.AddAttribute(63, "class", "btn btn-primary");
                __builder2.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                    EliminarPelActRol

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(65, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n            ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "button");
                __builder2.AddAttribute(69, "class", "btn btn-primary");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EliminarPeliculaActorRol.razor"
       
    [Parameter]
    public string Id {get; set;}
    PeliculaActorRol obj = new PeliculaActorRol();
    List<Pelicula> objPel;
    List<Actor> objAct;
    List<Rol> objRol;

    protected void EliminarPelActRol() {
        serv.Eliminar(obj);
        NavigationManager.NavigateTo("PeliculaActorRoles");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("PeliculaActorRoles");
    }

    protected override void OnInitialized()
    {
        obj = serv.Obtener(int.Parse(Id));
        objPel = servPel.obtenerTodo("");
        objAct = servAct.obtenerTodo("");
        objRol = servRol.obtenerTodo("");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioRoles servRol { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioActores servAct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioPelicula servPel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioPeliculaActorRol serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EliminarPeliculaActorRol
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
