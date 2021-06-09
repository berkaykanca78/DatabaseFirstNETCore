using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirstCore.Models
{
    public partial class DatabaseFirstContext : DbContext
    {
        public DatabaseFirstContext()
        {
        }

        public DatabaseFirstContext(DbContextOptions<DatabaseFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mevki> Mevkis { get; set; }
        public virtual DbSet<Oyuncu> Oyuncus { get; set; }
        public virtual DbSet<Takim> Takims { get; set; }
        public virtual DbSet<Ulke> Ulkes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OMV8BFU\\SQLEXPRESS;Database=DatabaseFirst;Trusted_Connection=True;");
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Mevki>(entity =>
            {
                entity.ToTable("Mevki");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MevkiAdi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Oyuncu>(entity =>
            {
                entity.ToTable("Oyuncu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Maas).HasColumnType("money");

                entity.Property(e => e.Soyadi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TakimId).HasColumnName("TakimID");

                entity.HasOne(d => d.MevkiNavigation)
                    .WithMany(p => p.Oyuncus)
                    .HasForeignKey(d => d.Mevki)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oyuncu_Mevki");

                entity.HasOne(d => d.Takim)
                    .WithMany(p => p.Oyuncus)
                    .HasForeignKey(d => d.TakimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oyuncu_Takim");

                entity.HasOne(d => d.UlkeNavigation)
                    .WithMany(p => p.Oyuncus)
                    .HasForeignKey(d => d.Ulke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oyuncu_Ulke");
            });

            modelBuilder.Entity<Takim>(entity =>
            {
                entity.ToTable("Takim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TakimAdi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ulke>(entity =>
            {
                entity.ToTable("Ulke");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UlkeAdi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
