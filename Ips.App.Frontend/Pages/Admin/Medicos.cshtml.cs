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
    public class MedicosAdminModel : PageModel
    { 

        private readonly IRepositorioMedico _repoMedico;

        public IEnumerable <Medico> medicos {get;set;}
        public Medico medico {get; set;}
        public MedicosAdminModel(IRepositorioMedico repoMedico )
        {
            _repoMedico = repoMedico;
        }
        public void OnGet()
        {
            medico=_repoMedico.ObtenerMedico(4);
            medicos=_repoMedico.ObtenerTodosMedico();
        }
        }
}
