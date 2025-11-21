using Domain.Entities;
using Infrastructure.Context.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ========== DbSets ==========
        public DbSet<HeritageSite> HeritageSites { get; set; }
        public DbSet<ArchitecturalElement> ArchitecturalElements { get; set; }
        public DbSet<ClimateData> ClimateData { get; set; }
        public DbSet<DamageReport> DamageReports { get; set; }
        public DbSet<ConservationPlan> ConservationPlans { get; set; }
        public DbSet<PlanProgress> PlanProgress { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Images Tables
        public DbSet<SiteImage> SiteImages { get; set; }
        public DbSet<ElementImage> ElementImages { get; set; }
        public DbSet<DamageImage> DamageImages { get; set; }
        public DbSet<PlanDocument> PlanDocuments { get; set; }
        public DbSet<ProgressImage> ProgressImages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ========== HeritageSite ==========
            builder.Entity<HeritageSite>(e =>
            {
                e.HasIndex(h => h.Governorate);
                e.HasIndex(h => h.Status);

                e.HasMany(h => h.ArchitecturalElements)
                 .WithOne(a => a.HeritageSite)
                 .HasForeignKey(a => a.HeritageSiteId)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasMany(h => h.Images)
                 .WithOne(i => i.HeritageSite)
                 .HasForeignKey(i => i.HeritageSiteId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // ========== ArchitecturalElement ==========
            builder.Entity<ArchitecturalElement>(e =>
            {
                e.HasIndex(a => a.MaterialType);
                e.HasIndex(a => a.CurrentCondition);

                e.HasMany(a => a.Images)
                 .WithOne(i => i.ArchitecturalElement)
                 .HasForeignKey(i => i.ArchitecturalElementId)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasMany(a => a.DamageReports)
                 .WithOne(d => d.ArchitecturalElement)
                 .HasForeignKey(d => d.ArchitecturalElementId)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // ========== ClimateData ==========
            builder.Entity<ClimateData>(e =>
            {
                e.HasIndex(c => c.RecordedAt);
                e.HasIndex(c => c.HeritageSiteId);
            });

            // ========== DamageReport ==========
            builder.Entity<DamageReport>(e =>
            {
                e.HasIndex(d => d.DamageType);
                e.HasIndex(d => d.Severity);
                e.HasIndex(d => d.Status);
                e.HasIndex(d => d.ReportedAt);

                e.HasOne(d => d.User)
                 .WithMany(u => u.DamageReports)
                 .HasForeignKey(d => d.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(d => d.ClimateData)
                 .WithMany()
                 .HasForeignKey(d => d.ClimateDataId)
                 .OnDelete(DeleteBehavior.SetNull);

                e.HasMany(d => d.Images)
                 .WithOne(i => i.DamageReport)
                 .HasForeignKey(i => i.DamageReportId)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasMany(d => d.ConservationPlans)
                 .WithOne(c => c.DamageReport)
                 .HasForeignKey(c => c.DamageReportId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // ========== ConservationPlan ==========
            builder.Entity<ConservationPlan>(e =>
            {
                e.HasIndex(c => c.Status);
                e.HasIndex(c => c.Priority);
                e.HasIndex(c => c.CreatedAt);

                e.HasOne(c => c.CreatedBy)
                 .WithMany(u => u.ConservationPlans)
                 .HasForeignKey(c => c.CreatedByUserId)
                 .OnDelete(DeleteBehavior.Restrict);

                e.HasMany(c => c.Documents)
                 .WithOne(d => d.ConservationPlan)
                 .HasForeignKey(d => d.ConservationPlanId)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasMany(c => c.ProgressUpdates)
                 .WithOne(p => p.ConservationPlan)
                 .HasForeignKey(p => p.ConservationPlanId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // ========== PlanProgress ==========
            builder.Entity<PlanProgress>(e =>
            {
                e.HasIndex(p => p.UpdatedAt);

                e.HasMany(p => p.Images)
                 .WithOne(i => i.PlanProgress)
                 .HasForeignKey(i => i.PlanProgressId)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            // ========== Article ==========
            builder.Entity<Article>(e =>
            {
                e.HasIndex(a => a.IsPublished);
                e.HasIndex(a => a.Category);
                e.HasIndex(a => a.PublishedAt);
            });

            // ========== Payment ==========
            builder.Entity<Payment>(e =>
            {
                e.HasIndex(p => p.PayPalTransactionId).IsUnique();
                e.HasIndex(p => p.Status);
                e.HasIndex(p => p.CreatedAt);

                e.HasOne(p => p.User)
                 .WithMany()
                 .HasForeignKey(p => p.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            // ========== 🌱 SEED DATA ==========
            SeedData.Seed(builder);
        }
    }
}