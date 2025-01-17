using GestaoGuincho.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGuincho.Infra.Data.FluentAPI
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Plate).HasMaxLength(8).IsRequired();
            builder.Property(v => v.Type).IsRequired();
            builder.Property(v => v.EntryDate).IsRequired();
        }
    }
}
