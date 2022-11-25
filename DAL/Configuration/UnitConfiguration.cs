using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Seeding;

namespace DAL.Configuration
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> modelBuilder)
        {
            modelBuilder
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Adress)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Owner)
                .WithMany(x => x.OwnedUnit);

            modelBuilder
                .HasMany(x => x.Issues)
                .WithOne(x => x.Unit);
            
            new UnitSeeder().Seeding(modelBuilder);
        }
    }
}
