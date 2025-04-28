using System.ComponentModel.DataAnnotations;

namespace PilamungaSEvaluacion.Models
{
    public class Reserva
    {
        [Required]
        public DateOnly FechaEntrada { get; set; }
        [Required]
        public DateOnly FechaSalida { get; set; }
        public int Valorpagar { get; set; }
        [Required]
        public String InformacionCliente { get; set; }
    }
}
