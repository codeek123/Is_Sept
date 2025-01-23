using Domain.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICourseService
    {
      public  List<Course> GetCourses();
        public Course GetCourseById(Guid? id);
        public Course CreateNewCourse(Course c);
        public Course UpdateCourse(Course c);
        public Course DeleteCourse(Guid id);

        public void FreeSpace(Course c);
    }
}
