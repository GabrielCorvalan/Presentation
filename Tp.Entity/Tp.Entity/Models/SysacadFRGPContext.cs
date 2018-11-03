using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class SysacadFRGPContext : DbContext
    {
        public SysacadFRGPContext()
        {
        }

        public SysacadFRGPContext(DbContextOptions<SysacadFRGPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Careers> Careers { get; set; }
        public virtual DbSet<CareersStudents> CareersStudents { get; set; }
        public virtual DbSet<CareersSubjets> CareersSubjets { get; set; }
        public virtual DbSet<ClassRooms> ClassRooms { get; set; }
        public virtual DbSet<Commisions> Commisions { get; set; }
        public virtual DbSet<CorrelativesSubjects> CorrelativesSubjects { get; set; }
        public virtual DbSet<StudentFinalTest> StudentFinalTest { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudentsMaters> StudentsMaters { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<SubjectsStates> SubjectsStates { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=SysacadFRGP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Careers>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CareerName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CareersStudents>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CareerId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StudentId).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.CareersStudents)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK__CareersSt__Caree__693CA210");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CareersStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__CareersSt__Stude__6B24EA82");
            });

            modelBuilder.Entity<CareersSubjets>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CareerId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ClassroomId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TeacherId).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.CareersSubjets)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK__CareersSu__Caree__5EBF139D");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.CareersSubjets)
                    .HasForeignKey(d => d.ClassroomId)
                    .HasConstraintName("FK__CareersSu__Class__628FA481");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CareersSubjets)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__CareersSu__Subje__60A75C0F");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.CareersSubjets)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__CareersSu__Teach__6477ECF3");
            });

            modelBuilder.Entity<ClassRooms>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ClassRomCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commisions>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CommisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrelativesSubjects>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectCorrelativeId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectId).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.SubjectCorrelative)
                    .WithMany(p => p.CorrelativesSubjectsSubjectCorrelative)
                    .HasForeignKey(d => d.SubjectCorrelativeId)
                    .HasConstraintName("FK__Correlati__Subje__7A672E12");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CorrelativesSubjectsSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__Correlati__Subje__787EE5A0");
            });

            modelBuilder.Entity<StudentFinalTest>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FinalTestDate).HasColumnType("date");

                entity.Property(e => e.StudentId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TeacherId).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentFi__Stude__4F7CD00D");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__StudentFi__Subje__4D94879B");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__StudentFi__Teach__5165187F");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentsMaters>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StudentId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectStateId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjetId).HasDefaultValueSql("(newsequentialid())");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentsMaters)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentsM__Stude__71D1E811");

                entity.HasOne(d => d.SubjectState)
                    .WithMany(p => p.StudentsMaters)
                    .HasForeignKey(d => d.SubjectStateId)
                    .HasConstraintName("FK__StudentsM__Subje__73BA3083");

                entity.HasOne(d => d.Subjet)
                    .WithMany(p => p.StudentsMaters)
                    .HasForeignKey(d => d.SubjetId)
                    .HasConstraintName("FK__StudentsM__Subje__6FE99F9F");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubjectsStates>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StateName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StudentId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SubjectId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TeacherId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TestDate).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Tests__StudentId__5812160E");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__Tests__SubjectId__5629CD9C");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Tests__TeacherId__59FA5E80");
            });
        }
    }
}
