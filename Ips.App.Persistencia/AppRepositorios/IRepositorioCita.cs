using System.Collections.Generic;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
    public interface IRepositorioCita
    {
        IEnumerable<Cita> ObtenerTodasCitas();
        Cita AñadirCita (Cita cita);
        Cita ActualizarCita (Cita cita);
        void EliminarCita (int idCita);
        Cita ObtenerCita (int idCita);        
        void AsignarPaciente(int idCita, int idPaciente);
        void AsignarHorario(int idCita, int idHorario);
        void AsignarMedico(int idCita, int idMedico);
        void AsignarSede(int idCita, int idSede);
    }
}