using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroupAssignment.Models
{
    public partial class FPTOjtDBContext : DbContext
    {
        public FPTOjtDBContext()
        {
        }

        public FPTOjtDBContext(DbContextOptions<FPTOjtDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CancelOjtRequestMsg> CancelOjtRequestMsgs { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<EvaluationReport> EvaluationReports { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<OjtRecord> OjtRecords { get; set; } = null!;
        public virtual DbSet<OjtRequestMsg> OjtRequestMsgs { get; set; } = null!;
        public virtual DbSet<RecruimentPost> RecruimentPosts { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(local); database = FPTOjtDB; Trusted_Connection = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CancelOjtRequestMsg>(entity =>
            {
                entity.ToTable("CancelOjtRequestMsg");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CancelOjtRequestMsg)
                    .HasForeignKey<CancelOjtRequestMsg>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CancelOjt__Semes__34C8D9D1");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.CancelOjtRequestMsg)
                    .HasForeignKey<CancelOjtRequestMsg>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CancelOjt__Stude__33D4B598");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EvaluationReport>(entity =>
            {
                entity.ToTable("EvaluationReport");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.EvaluationReport)
                    .HasForeignKey<EvaluationReport>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Evaluatio__OjtRe__3A81B327");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OjtRecord>(entity =>
            {
                entity.ToTable("OjtRecord");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.OjtRecord)
                    .HasForeignKey<OjtRecord>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OjtRecord__Reque__37A5467C");
            });

            modelBuilder.Entity<OjtRequestMsg>(entity =>
            {
                entity.ToTable("OjtRequestMsg");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.OjtRequestMsg)
                    .HasForeignKey<OjtRequestMsg>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OjtReques__Recru__30F848ED");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.OjtRequestMsg)
                    .HasForeignKey<OjtRequestMsg>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OjtReques__Stude__300424B4");
            });

            modelBuilder.Entity<RecruimentPost>(entity =>
            {
                entity.ToTable("RecruimentPost");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ContactPhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationEndDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkingAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RecruimentPost)
                    .HasForeignKey<RecruimentPost>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recruimen__Compa__2D27B809");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.RecruimentPost)
                    .HasForeignKey<RecruimentPost>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recruimen__Semes__2C3393D0");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("Semester");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cvlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CVLink");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DoB).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.Major)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
