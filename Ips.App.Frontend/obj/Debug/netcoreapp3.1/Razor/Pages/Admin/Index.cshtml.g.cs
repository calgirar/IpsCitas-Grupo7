#pragma checksum "C:\IpsForce\IpsCitas-Grupo7\Ips.App.Frontend\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2944a52789e8686ca05ab7e49191a7f03db9c69f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ips.App.Frontend.Pages.Admin.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
namespace Ips.App.Frontend.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2944a52789e8686ca05ab7e49191a7f03db9c69f", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de6a9dd9078b47f0d26e73a3b0884a7b07f2c66", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\IpsForce\IpsCitas-Grupo7\Ips.App.Frontend\Pages\Admin\Index.cshtml"
  
    ViewData["Title"] = "Inicio";
    ViewData["Current"] = "Inicio";
    Layout = "_LayoutAdmin";

    ViewData["pacienteNombre"] = @Model.paciente.Nombre;
    ViewData["pacienteNIT"] = @Model.paciente.NIT;
    ViewData["pacienteFechaNacimiento"] = @Model.paciente.FechaNacimiento;
    ViewData["pacienteCorreo"] = @Model.paciente.Correo;
    ViewData["pacienteTelefono"] = @Model.paciente.Telefono;
    ViewData["pacienteDireccion"] = @Model.paciente.Direccion;
    ViewData["pacienteCiudad"] = @Model.paciente.Ciudad;
    ViewData["pacienteGenero"] = @Model.paciente.Genero;
    ViewData["pacienteUsuario"] = @Model.paciente.Usuario;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ips.App.Frontend.Pages.IndexAdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ips.App.Frontend.Pages.IndexAdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ips.App.Frontend.Pages.IndexAdminModel>)PageContext?.ViewData;
        public Ips.App.Frontend.Pages.IndexAdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
