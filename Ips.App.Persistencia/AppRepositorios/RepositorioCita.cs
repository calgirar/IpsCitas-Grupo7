using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContext _appContext;

        public RepositorioCita(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Cita IRepositorioCita.AñadirCita(Cita cita)
        {
            var citaAdicionado = _appContext.Citas.Add(cita);
            _appContext.SaveChanges();
            return citaAdicionado.Entity;
        }

        void IRepositorioCita.EliminarCita(int idCita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(p => p.Id==idCita);
            if(citaEncontrado == null) 
                return;
            _appContext.Citas.Remove(citaEncontrado);
            _appContext.SaveChanges();
        }

        Cita IRepositorioCita.ObtenerCita(int idCita)
        {
            return _appContext.Citas.FirstOrDefault(p => p.Id==idCita);
        }

        IEnumerable<Cita> IRepositorioCita.ObtenerTodasCitas()
        {
            return _appContext.Citas;
        }

        Cita IRepositorioCita.ActualizarCita(Cita cita)
        {
            var citaEncontrado = _appContext.Citas.FirstOrDefault(p => p.Id==cita.Id);
            if(citaEncontrado != null)
            {
                citaEncontrado.NombrePaciente= cita.NombrePaciente;
                citaEncontrado.FechaHorario= cita.FechaHorario;
                citaEncontrado.NombreDoctor= cita.NombreDoctor;
                citaEncontrado.Especialidad= cita.Especialidad;
                citaEncontrado.TipoCita= cita.TipoCita;
                citaEncontrado.NombreSede= cita.NombreSede;
                citaEncontrado.DireccionSede= cita.DireccionSede;
                citaEncontrado.CiudadSede= cita.CiudadSede;
                citaEncontrado.Consultorio= cita.Consultorio;
                citaEncontrado.TelefonoSede= cita.TelefonoSede;

                _appContext.SaveChanges();
            }
            return citaEncontrado;
        }

    }
}