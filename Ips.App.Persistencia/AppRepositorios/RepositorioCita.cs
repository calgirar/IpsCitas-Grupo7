using System.Collections.Generic;
using Ips.App.Dominio;
using System.Linq;

namespace Ips.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        //private readonly AppContext _appContext;
        private readonly AppContext _appContext = new AppContext();

        /*
        public RepositorioCita(AppContext appContext)
        {
            _appContext=appContext;
        }
        /*/
        
        Cita IRepositorioCita.AñadirCita(Cita cita)
        {
            var citaAdicionado = _appContext.Citas.Add(cita);
            _appContext.SaveChanges();
            return citaAdicionado.Entity;
        }

        void IRepositorioCita.EliminarCita(int idCita)
        {
            var citaEncontrado = _appContext.Citas.Find(idCita);
            if(citaEncontrado == null) 
                return;
            _appContext.Citas.Remove(citaEncontrado);
            _appContext.SaveChanges();
        }

        Cita IRepositorioCita.ObtenerCita(int idCita)
        {
            return _appContext.Citas.Find(idCita);
        }

        IEnumerable<Cita> IRepositorioCita.ObtenerTodasCitas()
        {
            return _appContext.Citas;
        }

        Cita IRepositorioCita.ActualizarCita(Cita cita)
        {
            var citaEncontrado = _appContext.Citas.Find(cita.Id);
            if(citaEncontrado != null)
            {
                citaEncontrado.Paciente= cita.Paciente;
                citaEncontrado.Horario= cita.Horario;
                citaEncontrado.Doctor= cita.Doctor;
                citaEncontrado.TipoCita= cita.TipoCita;
                citaEncontrado.Sede= cita.Sede;

                _appContext.SaveChanges();
            }
            return citaEncontrado;
        }
        void IRepositorioCita.AsignarPaciente(int idCita, int idPaciente)
        {
            var citaEncontrada = _appContext.Citas.Find(idCita);
            if (citaEncontrada != null)
            {
                var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
                if (pacienteEncontrado != null)
                {
                    citaEncontrada.Paciente = pacienteEncontrado;
                    _appContext.SaveChanges();
                }
            }
        }
        void IRepositorioCita.AsignarHorario(int idCita, int idHorario)
        {
            var citaEncontrada = _appContext.Citas.Find(idCita);
            if (citaEncontrada != null)
            {
                var Encontrado = _appContext.Horarios.Find(idHorario);
                if (Encontrado != null)
                {
                    citaEncontrada.Horario = Encontrado;
                    _appContext.SaveChanges();
                }
            }
        }
        void IRepositorioCita.AsignarMedico(int idCita, int idMedico)
        {
            var citaEncontrada = _appContext.Citas.Find(idCita);
            if (citaEncontrada != null)
            {
                var Encontrado = _appContext.Medicos.Find(idMedico);
                if (Encontrado != null)
                {
                    citaEncontrada.Doctor = Encontrado;
                    _appContext.SaveChanges();
                }
            }
        }
        void IRepositorioCita.AsignarSede(int idCita, int idSede)
        {
            var citaEncontrada = _appContext.Citas.Find(idCita);
            if (citaEncontrada != null)
            {
                var Encontrado = _appContext.Sedes.Find(idSede);
                if (Encontrado != null)
                {
                    citaEncontrada.Sede = Encontrado;
                    _appContext.SaveChanges();
                }
            }
        }

    }
}