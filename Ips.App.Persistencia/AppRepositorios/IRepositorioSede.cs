using System.Collections.Generic;
using Ips.App.Dominio;

namespace Ips.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> ObtenerTodosSedes();
        Sede AñadirSede (Sede sede);
        Sede ActualizarSede (Sede sede);
        void EliminarSede (int idSede);
        Sede ObtenerSede (int idSede);        
    }
}