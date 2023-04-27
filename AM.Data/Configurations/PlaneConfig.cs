using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    internal class PlaneConfig : IEntityTypeConfiguration<Plane>//Implements
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes");
            builder.Property(P => P.Capacity).HasColumnName("PlaneCapacity");
            builder.HasKey(p => p.PlaneId);

        }
    }
}
