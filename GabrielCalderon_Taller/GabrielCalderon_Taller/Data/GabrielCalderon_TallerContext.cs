using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GabrielCalderon_Taller.Models;

namespace GabrielCalderon_Taller.Data
{
    public class GabrielCalderon_TallerContext : DbContext
    {
        public GabrielCalderon_TallerContext (DbContextOptions<GabrielCalderon_TallerContext> options)
            : base(options)
        {
        }

        public DbSet<GabrielCalderon_Taller.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<GabrielCalderon_Taller.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<GabrielCalderon_Taller.Models.Jugador> Jugador { get; set; } = default!;
    }
}
