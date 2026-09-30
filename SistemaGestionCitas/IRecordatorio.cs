namespace SistemaGestionCitas
{
    public interface IRecordatorio
    {
        void Enviar(Paciente paciente, Cita cita);
    }
}