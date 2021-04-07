using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.EfStuff.Model;
using WebApplication1.Models;

namespace WebApplication1.EfStuff
{
    public class KzDbContext : DbContext
    {
        public DbSet<Citizen> Citizens { get; set; }

        public DbSet<Adress> Adress { get; set; }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<TripRoute> TripRoute { get; set; }

        public KzDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>()
                .HasOne(x => x.House)
                .WithMany(x => x.Citizens);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bus>()
                .HasOne(x => x.RoutePlan)
                .WithMany(x => x.Buses);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<WebApplication1.Models.BusParkViewModel> BusParkViewModel { get; set; }
    }
}
