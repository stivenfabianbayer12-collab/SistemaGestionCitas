using System;

namespace SistemaGestionCitas
{
    public class RecordatorioCorreo : IRecordatorio
    {
        public void Enviar(Paciente paciente, Cita cita)
        {
            Console.WriteLine($"Enviando recordatorio a {paciente.Nombre} para su cita el {cita.FechaHora}");
        }
    }
}
