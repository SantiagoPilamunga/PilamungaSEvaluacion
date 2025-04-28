using System.ComponentModel.DataAnnotations;

namespace PilamungaSEvaluacion.Models
{
    //en reserva utilizamos lo que nos pide y tambien pusimos la key y otro como required
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        [Required]
        public DateOnly FechaEntrada { get; set; }
        [Required]
        public DateOnly FechaSalida { get; set; }
        public int Valorpagar { get; set; }
        [Required]
        public String InformacionCliente { get; set; }
    }
}
