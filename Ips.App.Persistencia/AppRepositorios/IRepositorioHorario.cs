using System.Collections.Generic;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
    public interface IRepositorioHorario
    {
        IEnumerable<Horario> ObtenerTodosHorarios();
        Horario AñadirHorario (Horario horario);
        Horario ActualizarHorario (Horario horario);
        void EliminarHorario (int idHorario);
        Horario ObtenerHorario (int idHorario);        
    }
}