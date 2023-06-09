﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class FlightConfiguration: IEntityTypeConfiguration<Flight>

    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.Property(f => f.Airline).IsRequired(false);
            builder.Property(f => f.Departure).IsRequired(false);
            builder.HasMany(f => f.Passengers).WithMany(p=>p.Flights);
            builder.HasOne(f => f.Plane).WithMany(p=>p.Flights).HasForeignKey(f=>f.PlaneId);
        }   
    }
}
