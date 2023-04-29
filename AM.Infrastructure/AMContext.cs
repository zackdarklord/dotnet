using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=AirportManagementDBzakaria;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Plane> Planes { get; set; }    
        public DbSet<Flight> Flights { get; set; }    
        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FlightConfiguration()); 
            modelBuilder.ApplyConfiguration(new PlaneConfiguration()); 
            modelBuilder.ApplyConfiguration(new PassengerConfiguration()); 
            modelBuilder.ApplyConfiguration(new TicketConfigration()); 

            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<Traveller>().ToTable("Traveller");
            modelBuilder.Entity<Passenger>().ToTable("Passenger");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //    // Pre-convention model configuration goes here
            //    configurationBuilder
            //        .Properties<string>()
            //        .HaveMaxLength(50);
            //configurationBuilder
            //    .Properties<decimal>()
            //        .HavePrecision(8,3);
            configurationBuilder
            .Properties<DateTime>()
            .HaveColumnType("date");
            

        }

    }


    }

