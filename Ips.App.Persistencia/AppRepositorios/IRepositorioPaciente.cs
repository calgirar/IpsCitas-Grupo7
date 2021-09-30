using System.Collections.Generic;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> ObtenerTodosPacientes();
        Paciente AñadirPaciente (Paciente paciente);
        Paciente ActualizarPaciente (Paciente paciente);
        void EliminarPaciente (int idPaciente);
        Paciente ObtenerPaciente (int idPaciente);        
    }
}