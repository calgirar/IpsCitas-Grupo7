#pragma checksum "C:\IpsForce\IpsCitas-Grupo7\Ips.App.Frontend\Pages\Medicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "806943174f512e52c05c6e79cf3278aa5d14d2ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ips.App.Frontend.Pages.Medicos.Pages_Medicos_Index), @"mvc.1.0.razor-page", @"/Pages/Medicos/Index.cshtml")]
namespace Ips.App.Frontend.Pages.Medicos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\IpsForce\IpsCitas-Grupo7\Ips.App.Frontend\Pages\_ViewImports.cshtml"
using Ips.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"806943174f512e52c05c6e79cf3278aa5d14d2ee", @"/Pages/Medicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de6a9dd9078b47f0d26e73a3b0884a7b07f2c66", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\IpsForce\IpsCitas-Grupo7\Ips.App.Frontend\Pages\Medicos\Index.cshtml"
  
    ViewData["Title"] = "Inicio";
    ViewData["Current"] = "Inicio";
    Layout = "_LayoutMedic";

    ViewData["medicoNombre"] = @Model.medico.Nombre;
    ViewData["medicoNIT"] = @Model.medico.NIT;
    ViewData["medicoFechaNacimiento"] = @Model.medico.FechaNacimiento;
    ViewData["medicoCorreo"] = @Model.medico.Correo;
    ViewData["medicoTelefono"] = @Model.medico.Telefono;
    ViewData["medicoDireccion"] = @Model.medico.Direccion;
    ViewData["medicoCiudad"] = @Model.medico.Ciudad;
    ViewData["medicoGenero"] = @Model.medico.Genero;
    ViewData["medicoUsuario"] = @Model.medico.Usuario;
    ViewData["medicoEspecialidad"] = @Model.medico.Especialidad;
    ViewData["medicoRegistroMedico"] = @Model.medico.RegistroMedico;
    ViewData["medicoConsultorio"] = @Model.medico.Consultorio;

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ips.App.Frontend.Pages.IndexMedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ips.App.Frontend.Pages.IndexMedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ips.App.Frontend.Pages.IndexMedModel>)PageContext?.ViewData;
        public Ips.App.Frontend.Pages.IndexMedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
