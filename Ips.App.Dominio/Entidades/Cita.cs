using System;

namespace Ips.App.Dominio
{
    public class Cita
    {
        public int Id {get;set;}
        public Paciente Paciente {get;set;}
        public Horario Horario {get;set;}
        public Medico Doctor {get;set;}
        public string TipoCita {get;set;}
        public Sede Sede {get;set;}
    }
}