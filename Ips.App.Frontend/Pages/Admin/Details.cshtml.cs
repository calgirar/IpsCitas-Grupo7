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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public Paciente paciente {get; set;}
        public DetailsModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public IActionResult OnGet(int id)
        {
            paciente= _repoPaciente.ObtenerPaciente(id);
            
            if (paciente == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
