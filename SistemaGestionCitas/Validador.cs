using System;

namespace SistemaGestionCitas
{
    public static class Validador
    {
        public static void ValidarNuloOVacio(string valor, string campo)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException($"El campo {campo} no puede estar vacío.");
        }

        public static void ValidarFechaFutura(DateTime fecha)
        {
            if (fecha <= DateTime.Now)
                throw new ArgumentException("La fecha de la cita debe ser en el futuro.");
        }
    }
}