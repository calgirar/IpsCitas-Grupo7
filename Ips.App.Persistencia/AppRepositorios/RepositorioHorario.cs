using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioHorario : IRepositorioHorario
    {
        private readonly AppContext _appContext;

        public RepositorioHorario(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Horario IRepositorioHorario.AñadirHorario(Horario horario)
        {
            var horarioAdicionado = _appContext.Horarios.Add(horario);
            _appContext.SaveChanges();
            return horarioAdicionado.Entity;
        }

        void IRepositorioHorario.EliminarHorario(int idHorario)
        {
            var horarioEncontrado = _appContext.Horarios.FirstOrDefault(p => p.Id==idHorario);
            if(horarioEncontrado == null) 
                return;
            _appContext.Horarios.Remove(horarioEncontrado);
            _appContext.SaveChanges();
        }

        Horario IRepositorioHorario.ObtenerHorario(int idHorario)
        {
            return _appContext.Horarios.FirstOrDefault(p => p.Id==idHorario);
        }

        IEnumerable<Horario> IRepositorioHorario.ObtenerTodosHorarios()
        {
            return _appContext.Horarios;
        }

        Horario IRepositorioHorario.ActualizarHorario(Horario horario)
        {
            var horarioEncontrado = _appContext.Horarios.FirstOrDefault(p => p.Id==horario.Id);
            if(horarioEncontrado != null)
            {
                horarioEncontrado.FechaHorario= horario.FechaHorario;
                _appContext.SaveChanges();
            }
            return horarioEncontrado;
        }

    }
}