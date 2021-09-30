using System;

namespace Ips.App.Dominio
{
    public class Cita
    {
        public int Id {get;set;}
        public Paciente NombrePaciente {get;set;}
        public Horario FechaHorario {get;set;}
        public Medico NombreDoctor {get;set;}
        public Medico Especialidad {get;set;}
        public string TipoCita {get;set;}
        public Sede NombreSede {get;set;}
        public Sede DireccionSede {get;set;}
        public Sede CiudadSede {get;set;}
        public Medico Consultorio {get;set;}
        public Sede TelefonoSede {get;set;}
    }
}