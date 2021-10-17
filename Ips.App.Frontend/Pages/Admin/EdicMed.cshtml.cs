using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Frontend.Pages.Medicos
{
    public class EdicMedModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;

        public Medico medico {get;set;}
        public EdicMedModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }
        public IActionResult OnGet(int id)
        {
            medico=_repoMedico.ObtenerMedico(id);
            if(medico == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }

        }
    }
}

