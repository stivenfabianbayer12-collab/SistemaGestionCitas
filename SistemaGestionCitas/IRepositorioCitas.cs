using System.Collections.Generic;

namespace SistemaGestionCitas
{
    public interface IRepositorioCitas
    {
        void Guardar(Cita cita);
        List<Cita> ObtenerPorPaciente(int pacienteId);
        List<Cita> ObtenerPorMedico(int medicoId);
        void Actualizar(Cita cita);
    }
}