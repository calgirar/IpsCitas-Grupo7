using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioPaciente:IRepositorioPaciente
    {
       
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Paciente IRepositorioPaciente.AñadirPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.EliminarPaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id==idPaciente);
            if(pacienteEncontrado == null) 
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        Paciente IRepositorioPaciente.ObtenerPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id==idPaciente);
        }

        IEnumerable<Paciente> IRepositorioPaciente.ObtenerTodosPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.ActualizarPaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id==paciente.Id);
            if(pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre= paciente.Nombre;
                pacienteEncontrado.Direccion= paciente.Direccion;
                pacienteEncontrado.Telefono= paciente.Telefono;
                pacienteEncontrado.NIT= paciente.NIT;
                pacienteEncontrado.Correo= paciente.Correo;
                pacienteEncontrado.Ciudad= paciente.Ciudad;
                pacienteEncontrado.Genero= paciente.Genero;
                pacienteEncontrado.Usuario= paciente.Usuario;
                pacienteEncontrado.Contraseña= paciente.Contraseña;
                pacienteEncontrado.Eps=paciente.Eps;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

    }
    
}