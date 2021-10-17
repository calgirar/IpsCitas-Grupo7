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
    public class apiCitaModel : PageModel
    {
        private readonly IRepositorioCita _repoCita;
        public apiCitaModel(IRepositorioCita repoCita)
        {
            _repoCita= repoCita;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()//Cita cita)
        {
            Console.WriteLine("Nombre: "+Request.Form["citaDia"]);
            
            /*
            paciente = _repoCita.ObtenerPaciente(1);
            var horario =new Horario
            {
                FechaHorario = "07/10/2021 10:30"
            };
            cita.Horario = horario;
            _repoCita.AñadirCita(cita);
            
            */
            return RedirectToPage("Index"); 
        }
    }
}
