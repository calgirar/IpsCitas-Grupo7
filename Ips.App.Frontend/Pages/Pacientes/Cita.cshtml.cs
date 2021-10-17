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
    public class CitaModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioCita _repoCita;
        private readonly IRepositorioHorario _repoHorario;
        private readonly IRepositorioMedico _repoMedico;
        private readonly IRepositorioSede _repoSede;
        public CitaModel(IRepositorioPaciente repoPaciente, IRepositorioCita repoCita, IRepositorioHorario repoHorario, IRepositorioMedico repoMedico, IRepositorioSede repoSede)
        {
            _repoPaciente= repoPaciente;
            _repoCita= repoCita;
            _repoHorario= repoHorario;
            _repoMedico= repoMedico;
            _repoSede= repoSede;
        }

        public Paciente paciente {get; set;}
        public Cita cita {get; set;}
        public string CitaDia {get; set;}
        public string CitaHora {get; set;}

        public void OnGet()
        {
            paciente= _repoPaciente.ObtenerPaciente(2);
            cita = new Cita();
            
            //paciente = _repoCita.ObtenerPaciente(1);
        }
        public IActionResult OnPost(Cita cita)//Cita cita)
        {
            paciente= _repoPaciente.ObtenerPaciente(2);

            var doctor= _repoMedico.ObtenerMedico(1);

            string date = Request.Form["citaDia"];
            string[] date_s = date.Split('-');
            string hour = Request.Form["CitaHora"];
            string[] hour_s = hour.Split(':');

            var horario = new Horario{ FechaHorario = new DateTime(Int16.Parse(date_s[0]), Int16.Parse(date_s[1]), Int16.Parse(date_s[2]), Int16.Parse(hour_s[0]), Int16.Parse(hour_s[1]), 00) };
            var horario_db = _repoHorario.AñadirHorario(horario);

            var sede= _repoSede.ObtenerSede(1);

            //cita.Paciente = paciente;
            //cita.Horario = horario_db;
            //cita.Doctor = doctor;
            //cita.Sede = sede;

            var cita_db = _repoCita.AñadirCita(cita);
            _repoCita.AsignarPaciente(cita_db.Id, paciente.Id);
            _repoCita.AsignarHorario(cita_db.Id, horario_db.Id);
            _repoCita.AsignarMedico(cita_db.Id, doctor.Id);
            _repoCita.AsignarSede(cita_db.Id, sede.Id);

            return RedirectToPage("Index"); 
        }
    }
}
