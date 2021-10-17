using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Frontend.Pages.Pacientes
{
    public class PacientesAdminModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public IEnumerable <Paciente> pacientes {get;set;}
        public Paciente paciente {get; set;}
        public PacientesAdminModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void OnGet()
        {
            paciente= _repoPaciente.ObtenerPaciente(3);
            pacientes=_repoPaciente.ObtenerTodosPacientes();
        }
    }
}
