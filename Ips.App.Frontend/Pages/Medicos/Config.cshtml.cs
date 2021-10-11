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
    public class ConfigMedModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public ConfigMedModel(IRepositorioMedico repoMedico)
        {
            _repoMedico= repoMedico;
        }
        public Medico medico {get; set;}
        public void OnGet()
        {
            medico= _repoMedico.ObtenerMedico(1);
        }
        public IActionResult OnPost(Medico medico)
        {
            _repoMedico.ActualizarMedico(medico);
            return RedirectToPage("Index");             
        }
    }
}
