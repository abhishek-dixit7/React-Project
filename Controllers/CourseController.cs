using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactProject.Services;

namespace ReactProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCourses()
        {
            var courses = await _courseService.GetAllCourses();
            return Ok(courses);
        }
    }
}
