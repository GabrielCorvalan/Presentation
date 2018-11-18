using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tp.Entity.Model
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

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Careers> Careers { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Classrooms> Classrooms { get; set; }
        public virtual DbSet<CorrelativesSubjects> CorrelativesSubjects { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PagesForRols> PagesForRols { get; set; }
        public virtual DbSet<PagesForUsers> PagesForUsers { get; set; }
        public virtual DbSet<PersonForAddress> PersonForAddress { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Rols> Rols { get; set; }
        public virtual DbSet<StudensPerSubject> StudensPerSubject { get; set; }
        public virtual DbSet<StudentFinalTest> StudentFinalTest { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudentsPerCareer> StudentsPerCareer { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<SubjectsPerCareer> SubjectsPerCareer { get; set; }
        public virtual DbSet<SubjectStates> SubjectStates { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SysacadFRGP;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Streets)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Address__CityId__5070F446");
            });

            modelBuilder.Entity<Careers>(entity =>
            {
                entity.Property(e => e.CareerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK__Cities__Province__3F466844");
            });

            modelBuilder.Entity<Classrooms>(entity =>
            {
                entity.Property(e => e.ClassromCode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CorrelativesSubjects>(entity =>
            {
                entity.HasOne(d => d.SubjectCorrelative)
                    .WithMany(p => p.CorrelativesSubjectsSubjectCorrelative)
                    .HasForeignKey(d => d.SubjectCorrelativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Correlati__Subje__6E01572D");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CorrelativesSubjectsSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Correlati__Subje__6D0D32F4");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK__Locations__Provi__3C69FB99");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tittle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PagesForRols>(entity =>
            {
                entity.HasOne(d => d.Page)
                    .WithMany(p => p.PagesForRols)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK__PagesForR__PageI__7B5B524B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PagesForRols)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PagesForR__UserI__7C4F7684");
            });

            modelBuilder.Entity<PagesForUsers>(entity =>
            {
                entity.HasOne(d => d.Page)
                    .WithMany(p => p.PagesForUsers)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK__PagesForU__PageI__778AC167");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PagesForUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PagesForU__UserI__787EE5A0");
            });

            modelBuilder.Entity<PersonForAddress>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PersonForAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PersonFor__Addre__5535A963");

                entity.HasOne(d => d.Students)
                    .WithMany(p => p.PersonForAddress)
                    .HasForeignKey(d => d.StudentsId)
                    .HasConstraintName("FK__PersonFor__Stude__5441852A");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PersonForAddress)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__PersonFor__Teach__534D60F1");
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Provinces__Count__398D8EEE");
            });

            modelBuilder.Entity<Rols>(entity =>
            {
                entity.Property(e => e.RolName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudensPerSubject>(entity =>
            {
                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudensPerSubject)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudensPe__Stude__5AEE82B9");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudensPerSubject)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__StudensPe__Subje__59FA5E80");

                entity.HasOne(d => d.SubjectState)
                    .WithMany(p => p.StudensPerSubject)
                    .HasForeignKey(d => d.SubjectStateId)
                    .HasConstraintName("FK__StudensPe__Subje__5BE2A6F2");
            });

            modelBuilder.Entity<StudentFinalTest>(entity =>
            {
                entity.Property(e => e.FinalTestDaye).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentFi__Stude__5FB337D6");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__StudentFi__Subje__5EBF139D");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.StudentFinalTest)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__StudentFi__Teach__60A75C0F");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surnames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentsPerCareer>(entity =>
            {
                entity.HasOne(d => d.Career)
                    .WithMany(p => p.StudentsPerCareer)
                    .HasForeignKey(d => d.CareerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentsP__Caree__693CA210");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentsPerCareer)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudentsP__Stude__6A30C649");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubjectsPerCareer>(entity =>
            {
                entity.HasOne(d => d.Career)
                    .WithMany(p => p.SubjectsPerCareer)
                    .HasForeignKey(d => d.CareerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubjectsP__Caree__6477ECF3");

                entity.HasOne(d => d.Classroom)
                    .WithMany(p => p.SubjectsPerCareer)
                    .HasForeignKey(d => d.ClassroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubjectsP__Class__656C112C");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectsPerCareer)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubjectsP__Subje__6383C8BA");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.SubjectsPerCareer)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubjectsP__Teach__66603565");
            });

            modelBuilder.Entity<SubjectStates>(entity =>
            {
                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Surnames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherNames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.Property(e => e.TestDate).HasColumnType("date");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Tests__StudentId__4AB81AF0");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__Tests__SubjectId__49C3F6B7");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Tests__TeacherId__4BAC3F29");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surnames)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK__Users__RolId__72C60C4A");
            });
        }
    }
}
