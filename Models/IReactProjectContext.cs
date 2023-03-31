using Microsoft.EntityFrameworkCore;

namespace ReactProject.Models
{
    public interface IReactProjectContext
    {
        DbSet<ContentLanguageMapping> ContentLanguageMappings { get; set; }
        DbSet<CourseContent> CourseContents { get; set; }
        DbSet<CourseMetadatum> CourseMetadata { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Enrollment> Enrollments { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<LearningPath> LearningPaths { get; set; }
        DbSet<LearningStatus> LearningStatuses { get; set; }
        DbSet<PathCourseMapping> PathCourseMappings { get; set; }
        DbSet<StudentLearningStatusView> StudentLearningStatusViews { get; set; }
        DbSet<Student> Students { get; set; }
    }
}