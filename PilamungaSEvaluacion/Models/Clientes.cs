using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace PilamungaSEvaluacion.Models
{
    public class Clientes
    {
        // dentro de clientes pusimos todo lo que nos pide y tambien lo utilizamos para el apartado de pla recompensas
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del cliente")]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public float DineroSeparar { get; set; } //monto de dinero que puso para separar la reserva
        public DateOnly FechaNacimiento { get; set; }
        public Boolean Asociado { get; set; }
        public int NumTotalReservas { get; set; }
        //public string Descripcion { get; set; }

    }
}
