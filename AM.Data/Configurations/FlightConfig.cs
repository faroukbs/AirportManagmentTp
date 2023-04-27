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
    internal class FlightConfig : IEntityTypeConfiguration<Flight>
    {
    public void Configure(EntityTypeBuilder<Flight> builder)
        {
             //builder.HasMany(f => f.passengers)
            //.WithMany(p => p.Flights)
            //.UsingEntity(t => t.ToTable("FP"));//changer le nom dans la BD
            builder.HasOne(f => f.MyPlane)
                .WithMany(p => p.flights)
                .HasForeignKey(f => f.PlaneId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
