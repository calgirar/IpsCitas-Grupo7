using System;

namespace Ips.App.Dominio
{
    public class Medico:Persona
    {
        public string Especialidad {get;set;}
        public string RegistroMedico {get;set;}
        public Horario FechaHorario {get;set;}
        public string Consultorio {get;set;}
    }
}