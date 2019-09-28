using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TiketeApi.Models
{
    public partial class City_TicketaContext : DbContext
    {
        public City_TicketaContext()
        {
        }

        public City_TicketaContext(DbContextOptions<City_TicketaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Citizen> Citizen { get; set; }
        public virtual DbSet<Government> Government { get; set; }
        public virtual DbSet<Municipality> Municipality { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Government>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.Property(e => e.Municipal).IsUnicode(false);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.TimeOfOccurence).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}