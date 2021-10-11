using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        /*
        public RepositorioMedico(AppContext appContext)
        {
            _appContext=appContext;
        }
        /*/

        Medico IRepositorioMedico.AñadirMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        void IRepositorioMedico.EliminarMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.Find(idMedico);
            if(medicoEncontrado == null) 
                return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }

        Medico IRepositorioMedico.ObtenerMedico(int idMedico)
        {
            return _appContext.Medicos.Find(idMedico);
        }

        IEnumerable<Medico> IRepositorioMedico.ObtenerTodosMedico()
        {
            return _appContext.Medicos;
        }

        Medico IRepositorioMedico.ActualizarMedico(Medico medico)
        {
            var medicoEncontrado = _appContext.Medicos.Find(medico.Id);
            if(medicoEncontrado != null)
            {
                medicoEncontrado.Nombre= medico.Nombre;
                medicoEncontrado.Direccion= medico.Direccion;
                medicoEncontrado.Telefono= medico.Telefono;
                medicoEncontrado.NIT= medico.NIT;
                medicoEncontrado.Correo= medico.Correo;
                medicoEncontrado.Ciudad= medico.Ciudad;
                medicoEncontrado.Genero= medico.Genero;
                medicoEncontrado.Usuario= medico.Usuario;
                medicoEncontrado.Contraseña= medico.Contraseña;
                medicoEncontrado.Especialidad= medico.Especialidad;
                medicoEncontrado.RegistroMedico= medico.RegistroMedico;
                medicoEncontrado.FechaHorario= medico.FechaHorario;
                medicoEncontrado.Consultorio= medico.Consultorio;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }

    }
}