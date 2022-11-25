using DAL.Configuration;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitContext:DbContext
    {
        public UnitContext(DbContextOptions<UnitContext> options) : base(options)
        {
        }
        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<Unit> Unit  { get; set; }
        public DbSet<EnergyConsume> EnergyConsume { get; set; }
        public DbSet<Issue> Issue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConsumerConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new EnergyConsumeConfiguration());
            modelBuilder.ApplyConfiguration(new IssueConfiguration());
        }
    }
}
