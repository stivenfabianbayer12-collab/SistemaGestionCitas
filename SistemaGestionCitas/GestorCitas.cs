using System;

namespace SistemaGestionCitas
{
    public class GestorCitas
    {
        private readonly IRepositorioCitas _repositorio;
        private readonly IRecordatorio _recordatorio;
        private int _contadorIds = 1;

        public GestorCitas(IRepositorioCitas repositorio, IRecordatorio recordatorio)
        {
            _repositorio = repositorio;
            _recordatorio = recordatorio;
        }

        public Cita AgendarCita(Paciente paciente, Medico medico, DateTime fecha)
        {
            Validador.ValidarFechaFutura(fecha);

            var nuevaCita = new Cita
            {
                Id = _contadorIds++,
                Paciente = paciente,
                Medico = medico,
                FechaHora = fecha,
                Estado = "Agendada"
            };

            _repositorio.Guardar(nuevaCita);
            _recordatorio.Enviar(paciente, nuevaCita);

            return nuevaCita;
        }

        public void CancelarCita(Cita cita)
        {
            cita.Estado = "Cancelada";
            _repositorio.Actualizar(cita);
        }

        public void ReprogramarCita(Cita cita, DateTime nuevaFecha)
        {
            Validador.ValidarFechaFutura(nuevaFecha);
            cita.FechaHora = nuevaFecha;
            cita.Estado = "Reprogramada";
            _repositorio.Actualizar(cita);
        }
    }
}