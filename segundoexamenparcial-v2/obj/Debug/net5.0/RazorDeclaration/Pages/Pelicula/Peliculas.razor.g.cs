// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace segundoexamenparcial_v2.Pages.Pelicula
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
#line 2 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Pelicula/Peliculas.razor"
using segundoexamenparcial_v2.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Pelicula/Peliculas.razor"
using segundoexamenparcial_v2.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Peliculas")]
    public partial class Peliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/home/alonso/Documentos/desappint21/segundoexamenparcial-v2/Pages/Pelicula/Peliculas.razor"
       
    List<Pelicula> obj;
    List<Genero> objGen;
    List<Certificado> objCert;

    protected override void OnInitialized()
    {
        obj = serv.obtenerTodo("");
        objGen = servGen.obtenerTodo("");
        objCert = servCert.obtenerTodo("");
    }    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCertificados servCert { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioGenero servGen { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioPelicula serv { get; set; }
    }
}
#pragma warning restore 1591
