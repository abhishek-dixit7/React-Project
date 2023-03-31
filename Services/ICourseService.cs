using ReactProject.Models;

namespace ReactProject.Services
{
    public interface ICourseService
    {
        Task<IList<Course>> GetAllCourses();
    }
}