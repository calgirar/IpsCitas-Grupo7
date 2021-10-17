using System;

namespace Ips.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre {get;set;}
        public int NIT {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public string Correo {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public string Genero {get;set;}
        public string Usuario {get;set;}
        public string Contraseña {get;set;}
    }
}