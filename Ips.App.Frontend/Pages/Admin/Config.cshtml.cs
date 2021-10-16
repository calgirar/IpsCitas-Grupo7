using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Frontend.Pages
{
    public class ConfigAdminModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get; set;}
        public ConfigAdminModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente= repoPaciente;
        }

        public void OnGet()
        {
            paciente= _repoPaciente.ObtenerPaciente(3);
            // TODO: Esperando clases de sesiones
        }
        public IActionResult OnPost(Paciente paciente)
        {
            _repoPaciente.ActualizarPaciente(paciente);
            return RedirectToPage("Index");             
        }
    }
}
