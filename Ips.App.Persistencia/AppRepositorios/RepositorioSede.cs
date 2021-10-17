using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        /*
        public RepositorioSede(AppContext appContext)
        {
            _appContext=appContext;
        }
        /*/

        Sede IRepositorioSede.AñadirSede(Sede sede)
        {
            var sedeAdicionado = _appContext.Sedes.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionado.Entity;
        }

        void IRepositorioSede.EliminarSede(int idSede)
        {
            var sedeEncontrado = _appContext.Sedes.Find(idSede);
            if(sedeEncontrado == null) 
                return;
            _appContext.Sedes.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

        Sede IRepositorioSede.ObtenerSede(int idSede)
        {
            return _appContext.Sedes.Find(idSede);
        }

        IEnumerable<Sede> IRepositorioSede.ObtenerTodosSedes()
        {
            return _appContext.Sedes;
        }

        Sede IRepositorioSede.ActualizarSede(Sede sede)
        {
            var sedeEncontrado = _appContext.Sedes.Find(sede.Id);
            if(sedeEncontrado != null)
            {
                sedeEncontrado.NombreSede= sede.NombreSede;
                sedeEncontrado.DireccionSede= sede.DireccionSede;
                sedeEncontrado.CiudadSede= sede.CiudadSede;
                sedeEncontrado.TelefonoSede= sede.TelefonoSede;

                _appContext.SaveChanges();
            }
            return sedeEncontrado;
        }

    }
}