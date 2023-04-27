using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    internal class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.MyFullName)
                .Property(fn => fn.FirstName).HasMaxLength(30)
                .HasColumnName("Name");
            builder.OwnsOne(p => p.MyFullName)
                .Property(fn => fn.LastName).IsRequired();
            //tp5.1
            //builder.HasDiscriminator<int>("IsTraveller")
            //    .HasValue<Passenger>(0)
            //    .HasValue<Staff>(2)
            //    .HasValue<Traveller>(1);
            
                
        }
    }
}
