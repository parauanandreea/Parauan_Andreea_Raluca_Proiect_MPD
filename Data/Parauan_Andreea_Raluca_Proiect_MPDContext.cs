using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parauan_Andreea_Raluca_Proiect_MPD.Models;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Data
{
    public class Parauan_Andreea_Raluca_Proiect_MPDContext : DbContext
    {
        public Parauan_Andreea_Raluca_Proiect_MPDContext (DbContextOptions<Parauan_Andreea_Raluca_Proiect_MPDContext> options)
            : base(options)
        {
        }

        public DbSet<Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_MPD> Proiect_MPD { get; set; } = default!;

        public DbSet<Parauan_Andreea_Raluca_Proiect_MPD.Models.Fondul_Structural>? Fondul_Structural { get; set; }

        public DbSet<Parauan_Andreea_Raluca_Proiect_MPD.Models.Tip_ajutor>? Tip_ajutor { get; set; }

        public DbSet<Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_depus>? Proiect_depus { get; set; }

     
    }
}
