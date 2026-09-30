using System.Collections.Generic;
using System.Linq;

namespace SistemaGestionCitas
{
    public class RepositorioCitasMemoria : IRepositorioCitas
    {
        private List<Cita> _citas = new List<Cita>();

        public void Guardar(Cita cita) => _citas.Add(cita);

        public List<Cita> ObtenerPorPaciente(int pacienteId) =>
            _citas.Where(c => c.Paciente.Id == pacienteId).ToList();

        public List<Cita> ObtenerPorMedico(int medicoId) =>
            _citas.Where(c => c.Medico.Id == medicoId).ToList();

        public void Actualizar(Cita cita)
        {
            var existente = _citas.FirstOrDefault(c => c.Id == cita.Id);
            if (existente != null)
            {
                existente.Estado = cita.Estado;
                existente.FechaHora = cita.FechaHora;
            }
        }
    }
}