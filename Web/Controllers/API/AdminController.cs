using Domain.Domain_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ISemesterService _semesterService;
        private readonly ICourseService _courseService;

        public AdminController(IStudentService studentService, ISemesterService semesterService, ICourseService courseService)
        {
            _studentService = studentService;
            _semesterService = semesterService;
            _courseService = courseService;
        }

        [HttpGet("[action]")]
        public List<Student> GetStudents()
        {
            return this._studentService.GetStudents();
        }

        [HttpGet("[action]")]
        public List<Semester> GetSemesters()
        {
            return this._semesterService.GetSemesters();
        }

        [HttpGet("[action]")]
        public List<Course> GetCourses()
        {
            return this._courseService.GetCourses();
        }

        [HttpPost("[action]")]
        public Course GetDetails(BaseEntity id)
        {
            return this._courseService.GetCourseById(id.Id);
        }
    }
}
