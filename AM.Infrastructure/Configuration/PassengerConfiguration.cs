using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class PassengerConfiguration :  IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName).Property(f=>f.FirstName).HasMaxLength(30).HasColumnName("PassFirstName") ;
            builder.OwnsOne(p => p.FullName).Property(f=>f.LastName).IsRequired().HasColumnName("PassLastName");

        }
    }
}
