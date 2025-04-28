using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PilamungaSEvaluacion.Models;

namespace PilamungaSEvaluacion.Data
{
    public class PilamungaSEvaluacionContext : DbContext
    {
        public PilamungaSEvaluacionContext (DbContextOptions<PilamungaSEvaluacionContext> options)
            : base(options)
        {
        }

        public DbSet<PilamungaSEvaluacion.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<PilamungaSEvaluacion.Models.Reserva> Reserva { get; set; } = default!;
        public DbSet<PilamungaSEvaluacion.Models.PlandeRecompensas> PlandeRecompensas { get; set; } = default!;
    }
}
