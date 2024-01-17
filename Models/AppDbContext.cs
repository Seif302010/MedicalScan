using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MedicalScan.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<Speciality> Specialities { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctors");

                entity.HasIndex(e => e.Name, "UQ__doctors__737584F6691E2A57")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasMany(d => d.Specialities)
                    .WithMany(p => p.Doctors)
                    .UsingEntity<Dictionary<string, object>>(
                        "DoctorsSpeciality",
                        l => l.HasOne<Speciality>().WithMany().HasForeignKey("SpecialityId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__doctors_s__Speci__45F365D3"),
                        r => r.HasOne<Doctor>().WithMany().HasForeignKey("DoctorId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__doctors_s__Docto__44FF419A"),
                        j =>
                        {
                            j.HasKey("DoctorId", "SpecialityId").HasName("PK__doctors___8BBED8D0E2CF5C05");

                            j.ToTable("doctors_specialities");

                            j.IndexerProperty<int>("DoctorId").HasColumnName("DoctorID");

                            j.IndexerProperty<int>("SpecialityId").HasColumnName("SpecialityID");
                        });
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("specialities");

                entity.HasIndex(e => e.Name, "UQ__speciali__737584F633AABC73")
                    .IsUnique();

                entity.HasIndex(e => e.Code, "UQ__speciali__A25C5AA739BAE280")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
