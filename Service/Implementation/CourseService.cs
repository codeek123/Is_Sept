using Domain.Domain_Models;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;

        public CourseService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Course CreateNewCourse(Course c)
        {
           return _courseRepository.Insert(c);
        }

        public Course DeleteCourse(Guid id)
        {
            var course = this.GetCourseById(id);
            return _courseRepository.Delete(course);
        }

        public void FreeSpace(Course c)
        {
            --c.AavailableSlots;
        }

        public Course GetCourseById(Guid? id)
        {
            var course = _courseRepository.Get(id);
            return course;
        }

        public List<Course> GetCourses()
        {
            return _courseRepository.GetAll().ToList();
        }

        public Course UpdateCourse(Course c)
        {
           return _courseRepository.Update(c);
        }

       
    }
}
