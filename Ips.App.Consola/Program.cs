using System;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Consola
{
    class Program
    {
        //private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente();
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            BuscarPaciente(1);
            //EliminarPaciente(2);
            //ActualizarPaciente();          
                        
        }
        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Carlos Prueba",
                NIT=1234526,
                FechaNacimiento = new DateTime(2010, 8, 18),
                Correo="caruiz@gmail.com",
                Telefono="412341535",
                Direccion="Carrera 34 #6-32",
                Ciudad="Manizales",
                Genero="Masculino",
                Usuario="crlruiz",
                Contraseña="fjksdoiq",
                Eps= "Compensar"
            };
            _repoPaciente.AñadirPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.ObtenerPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre);
        } 
        private static void EliminarPaciente (int idPaciente)
        {
            _repoPaciente.EliminarPaciente(idPaciente);
        }
        private static void ActualizarPaciente()
        {
            var paciente =new Paciente
            {
                Id=1,
                Nombre="fdsafsa Prueba",
                NIT=1234526,
                FechaNacimiento = new DateTime(2010, 8, 18),
                Correo="caruiz@gmail.com",
                Telefono="412341535",
                Direccion="Carrera 34 #6-32",
                Ciudad="Manizales",
                Genero="Masculino",
                Usuario="crlruiz",
                Contraseña="fjksdoiq",
                Eps= "Compensar"
            };
            _repoPaciente.ActualizarPaciente(paciente);
        }
    }
}