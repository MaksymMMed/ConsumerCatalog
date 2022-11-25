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
    public class ConsumerConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> modelBuilder)
        {
            modelBuilder
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .HasMany(x => x.OwnedUnit)
                .WithOne(x => x.Owner);
            
            new ConsumerSeeder().Seeding(modelBuilder);
        }
    }
}
