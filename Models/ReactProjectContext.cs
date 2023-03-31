using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReactProject.Models;

public partial class ReactProjectContext : DbContext, IReactProjectContext
{
    public ReactProjectContext()
    {
    }

    public ReactProjectContext(DbContextOptions<ReactProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContentLanguageMapping> ContentLanguageMappings { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseContent> CourseContents { get; set; }

    public virtual DbSet<CourseMetadatum> CourseMetadata { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LearningPath> LearningPaths { get; set; }

    public virtual DbSet<LearningStatus> LearningStatuses { get; set; }

    public virtual DbSet<PathCourseMapping> PathCourseMappings { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentLearningStatusView> StudentLearningStatusViews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=TIHLT-1346;Initial Catalog=ReactProject;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContentLanguageMapping>(entity =>
        {
            entity.ToTable("ContentLanguageMapping");

            entity.Property(e => e.ContentPath).IsUnicode(false);
            entity.Property(e => e.TopicName).HasMaxLength(100);
            entity.Property(e => e.TopicSummary).IsUnicode(false);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.Property(e => e.CourseDescription).IsUnicode(false);
            entity.Property(e => e.CourseName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CourseContent>(entity =>
        {
            entity.HasKey(e => e.ContentId);

            entity.ToTable("CourseContent");

            entity.Property(e => e.ContentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsPaid)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CourseMetadatum>(entity =>
        {
            entity.HasKey(e => e.MetadataId);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Metadata)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MetadataType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.ToTable("Enrollment");

            entity.Property(e => e.EnrollmentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CancelledReason).IsUnicode(false);
            entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LanguageName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LearningPath>(entity =>
        {
            entity.ToTable("LearningPath");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Image)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PathDescription).IsUnicode(false);
            entity.Property(e => e.PathName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LearningStatus>(entity =>
        {
            entity.ToTable("LearningStatus");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DateCompleted).HasColumnType("datetime");
            entity.Property(e => e.DateStarted).HasColumnType("datetime");
        });

        modelBuilder.Entity<PathCourseMapping>(entity =>
        {
            entity.ToTable("PathCourseMapping");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefaultLanguageId).HasDefaultValueSql("((1))");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).IsUnicode(false);
            entity.Property(e => e.Profession)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Qualification)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StudentLearningStatusView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StudentLearningStatusView");

            entity.Property(e => e.DateCompleted).HasColumnType("datetime");
            entity.Property(e => e.DateStarted).HasColumnType("datetime");
            entity.Property(e => e.TopicName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
