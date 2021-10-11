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
    public class AddMedicModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public AddMedicModel(IRepositorioMedico repoMedico)
        {
            _repoMedico= repoMedico;
        }
        public Medico medico {get; set;}
        public Medico medico_n {get; set;}
        public void OnGet()
        {
            medico= _repoMedico.ObtenerMedico(1);
            medico_n=  new Medico();
        }
        public IActionResult OnPost(Medico medico_n)
        {
            _repoMedico.AñadirMedico(medico_n);
            return RedirectToPage("Index");             
        }
    }
}
