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
    public class RegisterModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioMedico _repoMedico;
        public RegisterModel(IRepositorioPaciente repoPaciente, IRepositorioMedico repoMedico)
        {
            _repoPaciente= repoPaciente;
            _repoMedico= repoMedico;
        }
        public Paciente paciente {get; set;}
        public void OnGet()
        {
            paciente= new Paciente(); 
        }
        public IActionResult OnPost(Paciente paciente)
        {
            _repoPaciente.AñadirPaciente(paciente);
            return RedirectToPage("Admin/Index");             
        }
    }
}
