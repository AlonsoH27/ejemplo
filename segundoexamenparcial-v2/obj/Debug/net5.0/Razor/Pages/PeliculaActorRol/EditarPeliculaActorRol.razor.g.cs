#pragma checksum "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ad3d504bbf3213d712e5050c01d5e90e414772"
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
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
using segundoexamenparcial_v2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
using segundoexamenparcial_v2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarPeliculaActorRol/{Id}")]
    public partial class EditarPeliculaActorRol : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar pelicula-actor-rol</h3>\n\n ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                           ActualizarPeliculaActorRoles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"PeliculaId\" class=\"control-label\">Pelicula Id</label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EditarPeliculaActorRol.TypeInference.CreateInputSelect_0(__builder2, 16, 17, "PeliculaId", 18, "form-control", 19, 
#nullable restore
#line 19 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                               obj.PeliculaId

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.PeliculaId = __value, obj.PeliculaId)), 21, () => obj.PeliculaId, 22, (__builder3) => {
#nullable restore
#line 20 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                     foreach (var p in @objPel)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(23, "option");
                    __builder3.AddAttribute(24, "value", 
#nullable restore
#line 22 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                        p.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(25, 
#nullable restore
#line 22 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                               p.Titulo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label for=\"ActorId\" class=\"control-label\">Actor Id </label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EditarPeliculaActorRol.TypeInference.CreateInputSelect_1(__builder2, 30, 31, "ActorId", 32, "form-control", 33, 
#nullable restore
#line 28 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                            obj.ActorId

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.ActorId = __value, obj.ActorId)), 35, () => obj.ActorId, 36, (__builder3) => {
#nullable restore
#line 29 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                     foreach (var ac in @objAct)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(37, "option");
                    __builder3.AddAttribute(38, "value", 
#nullable restore
#line 31 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                        ac.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(39, 
#nullable restore
#line 31 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                ac.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 32 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"RolId\" class=\"control-label\">Rol Id </label>\n                ");
                __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EditarPeliculaActorRol.TypeInference.CreateInputSelect_2(__builder2, 44, 45, "RolId", 46, "form-control", 47, 
#nullable restore
#line 37 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                          obj.RolId

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.RolId = __value, obj.RolId)), 49, () => obj.RolId, 50, (__builder3) => {
#nullable restore
#line 38 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                     foreach (var r in @objRol)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 40 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                        r.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(53, 
#nullable restore
#line 40 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                               r.Tipo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 41 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label for=\"Personaje\" class=\"control-label\">Personaje </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "id", "Personaje");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                            obj.Personaje

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Personaje = __value, obj.Personaje))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Personaje));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "<label for=\"Descripcion\" class=\"control-label\">Descripción </label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "id", "Descripcion");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                              obj.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Descripcion = __value, obj.Descripcion))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n            ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-primary\">Guardar</button>\n            ");
                __builder2.OpenElement(76, "button");
                __builder2.AddAttribute(77, "type", "button");
                __builder2.AddAttribute(78, "class", "btn btn-primary");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(80, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/PeliculaActorRol/EditarPeliculaActorRol.razor"
       
    [Parameter]
    public string Id {get; set;}
    PeliculaActorRol obj = new PeliculaActorRol();
    List<Pelicula> objPel;
    List<Actor> objAct;
    List<Rol> objRol;

    protected void ActualizarPeliculaActorRoles() {
        serv.Actualizar(obj);
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
namespace __Blazor.segundoexamenparcial_v2.Pages.PeliculaActorRol.EditarPeliculaActorRol
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
