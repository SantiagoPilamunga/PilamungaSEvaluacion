using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PilamungaSEvaluacion.Models
{
    public class PlandeRecompensas : Clientes
    {
        
        [Required]
        public DateOnly FechaInicio { get; set; }
        public int Puntos {  get; set; }
    }
}
