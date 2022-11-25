using DAL.Entities;
using DAL.Seeding;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{
    public class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> modelBuilder)
        {
            modelBuilder
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Unit)
                .WithMany(x => x.Issues);

        new IssueSeeder().Seeding(modelBuilder);
        }
    }
}
