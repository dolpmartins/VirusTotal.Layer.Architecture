using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

using Teste.Domain.Entities;

namespace Teste.Infra.Data.Context
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Report>()
            .HasOne(x => x.scan)
            .WithOne(x => x.report)
            .HasPrincipalKey<Scan>(x => x.scan_id)
            .HasForeignKey<Report>(x => x.scan_id);


            base.OnModelCreating(modelBuilder);



        }

        public override int SaveChanges()
        {
            PopulateAuditFields();
            return base.SaveChanges();
        }

        private void PopulateAuditFields()
        {
            foreach (var item in ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity is BaseEntity))
            {
                var actualItem = (BaseEntity)item.Entity;
                actualItem.CreatedDate = DateTime.Now;
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Modified || e.Collections.Any(c => c.IsModified))))
            {
                var actualItem = (BaseEntity)item.Entity;
                Entry(actualItem).Property(p => p.CreatedDate).IsModified = false;
            }
        }
        public DbSet<CATQuickHeal> CATQuickHeal { get; set; }
        public DbSet<McAfee> McAfee { get; set; }
        public DbSet<NProtect> NProtect { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Scan> Scan { get; set; }
        public DbSet<Scans> Scans { get; set; }
        public DbSet<TheHacker> TheHacker { get; set; }
        public DbSet<VirusBuster> VirusBuster { get; set; }
    }
}
