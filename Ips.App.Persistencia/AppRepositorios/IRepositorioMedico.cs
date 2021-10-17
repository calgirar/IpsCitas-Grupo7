using System.Collections.Generic;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> ObtenerTodosMedico();
        Medico AñadirMedico (Medico doctor);
        Medico ActualizarMedico (Medico doctor);
        void EliminarMedico (int idMedico);
        Medico ObtenerMedico (int idMedico);        
    }
}