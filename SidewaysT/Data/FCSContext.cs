using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SidewaysT.Models
{
    public class FCSContext : DbContext
    {
        public FCSContext (DbContextOptions<FCSContext> options)
            : base(options)
        {
        }

        public DbSet<WCat> WCat { get; set; }
        public DbSet<TypeDef> TypeDef { get; set; }
        public DbSet<Weapon> Weapon { get; set; }
        public DbSet<Ammo> Ammo { get; set; }
        public DbSet<AmmoVolley> AmmoVolley { get; set; }
        public DbSet<RangeCat> RangeCat { get; set; }
        public DbSet<Range> Range { get; set; }     
    }
}
