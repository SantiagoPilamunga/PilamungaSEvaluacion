using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PilamungaSEvaluacion.Models
{
    // dentro de este heredamos directamente de cliente para no tener que repetir las cosas y solo agregamos puntos el tipo de recompensay la fecha
    public class PlandeRecompensas : Clientes
    {
        
        [Required]
        public DateOnly FechaInicio { get; set; }
        public int Puntos {  get; set; }
        public String TipoRecompensa
        {
            get
            {
                if (Puntos < 500)
                    return "SILVER";
                else
                    return "GOLD";
            }
        }
    }
}
