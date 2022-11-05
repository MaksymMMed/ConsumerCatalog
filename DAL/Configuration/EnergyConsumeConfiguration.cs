using DAL.Entities;
using DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class EnergyConsumeConfiguration : IEntityTypeConfiguration<EnergyConsume>
    {
        public void Configure(EntityTypeBuilder<EnergyConsume> modelBuilder)
        {
            modelBuilder.
                HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.SizeDay)
                .IsRequired();

            modelBuilder
                .Property(x => x.SizeNight)
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Unit)
                .WithMany(x => x.ConsumeEnergy);

            new EnergyConsumeSeeder().Seeding(modelBuilder);
        }
    }
}
