﻿using AM.ApplicationCore.Domain;
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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Plane> Planes { get; set; }    
        public DbSet<Flight> Flights { get; set; }    
        public DbSet<Passenger> Passengers { get; set; }    
    }
}
