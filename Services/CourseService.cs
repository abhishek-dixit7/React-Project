using Microsoft.EntityFrameworkCore;
using ReactProject.Models;

namespace ReactProject.Services
{
    public class CourseService : ICourseService
    {
        private readonly IReactProjectContext _dbContext;

        public CourseService(IReactProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<Course>> GetAllCourses()
        {
            return await _dbContext.Courses.ToListAsync();

        }
    }
}
