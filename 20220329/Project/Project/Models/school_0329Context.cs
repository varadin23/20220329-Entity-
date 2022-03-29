using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project.Models
{
    public partial class school_0329Context : DbContext
    {
        public school_0329Context()
        {
        }

        public school_0329Context(DbContextOptions<school_0329Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ProjectStudent> ProjectStudents { get; set; }
        public virtual DbSet<ProjectSubject> ProjectSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=school_0329;user=root;password=;SSL mode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectStudent>(entity =>
            {
                entity.ToTable("project_student");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProjectSubject>(entity =>
            {
                entity.ToTable("project_subject");

                entity.HasIndex(e => e.StudentId, "project_subject_student_id_fk");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.StudentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Student_id");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ProjectSubjects)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("project_subject_student_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
