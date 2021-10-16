using System;
using Ips.App.Dominio;
using Ips.App.Persistencia;

namespace Ips.App.Consola
{
    class Program
    {
        //private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente();
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioHorario _repoHorario= new RepositorioHorario();
        private static IRepositorioCita _repoCita= new RepositorioCita();
        private static IRepositorioMedico _repoMedico= new RepositorioMedico();
        private static IRepositorioSede _repoSede= new RepositorioSede();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDoc();
            //AddSede();
            //AddPaciente();
            //BuscarPaciente(1);
            EliminarPaciente(4);
            //ActualizarPaciente();
            //AddCita();
            //BuscarHora();
                        
        }
        private static void AddCita()
        {
            var Horario =new Horario
            {
                FechaHorario = new DateTime(2021, 10, 6)   
            };
            _repoHorario.AñadirHorario(Horario);
        }
        private static void BuscarHora()
        {
            var horario = _repoHorario.ObtenerTodosHorarios();
            foreach (var item in horario)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.FechaHorario);
            }
        } 
        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Camilo Beltran Alvarez",
                NIT=1234526,
                FechaNacimiento = new DateTime(1995, 8, 18),
                Correo="camba@gmail.com",
                Telefono="412341535",
                Direccion="Carrera 34 #6-32",
                Ciudad="Manizales",
                Genero="Masculino",
                Usuario="camba",
                Contraseña="fjksdoiq",
                Eps= "Compensar"
            };
            _repoPaciente.AñadirPaciente(paciente);
        }

        private static void AddAdmin()
        {
            var paciente =new Paciente
            {
                Nombre="Admin",
                NIT=1,
                FechaNacimiento = new DateTime(2021, 1, 1),
                Correo="admin@ipsconfig.com",
                Telefono="Admin",
                Direccion="Admin",
                Ciudad="Admin",
                Genero="Admin",
                Usuario="Admin",
                Contraseña="000000000",
                Eps= "Admin"
            };
            _repoPaciente.AñadirPaciente(paciente);
        }
        private static void AddDoc()
        {
            var doctor =new Medico
            {
                Nombre="Rosario Vasques Cardona",
                NIT=16814684,
                FechaNacimiento = new DateTime(1985, 10, 8),
                Correo="rosarioVas@gmail.com",
                Telefono="1641684684",
                Direccion="Carrera 3 #2-32",
                Ciudad="Manizales",
                Genero="Femenino",
                Usuario="rosaVa",
                Contraseña="sdfsdfds"
            };
            _repoMedico.AñadirMedico(doctor);
        }
        private static void AddSede()
        {
            var sede =new Sede
            {
                NombreSede="IPS Salud Integral Manizales",
                DireccionSede= "Calle 14 #58-41",
                CiudadSede = "Manizales",
                TelefonoSede = "318616"
            };
            _repoSede.AñadirSede(sede);

            var sede1 =new Sede
            {
                NombreSede="IPS Salud Integral Bogotá",
                DireccionSede= "Calle 16 #48-16",
                CiudadSede = "Bogotá",
                TelefonoSede = "168146"
            };

            _repoSede.AñadirSede(sede1);
            var sede2 =new Sede
            {
                NombreSede="IPS Salud Integral Medellín",
                DireccionSede= "Calle 42 #15-198",
                CiudadSede = "Medellín",
                TelefonoSede = "2684168"
            };
            _repoSede.AñadirSede(sede2);
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