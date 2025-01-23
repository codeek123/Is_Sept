using Domain.Domain_Models;
using Domain.DTO;
using Repository.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class StudentOnCourseService : IStudentOnCourseService
    {
        private readonly IRepository<StudentOnCourse> _scRepository;
        private readonly IRepository<Course> _courseRepository;
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Semester> _semester_repository;

        public StudentOnCourseService(IRepository<StudentOnCourse> scRepository, IRepository<Course> courseRepository, IRepository<Student> studentRepository, IRepository<Semester> semester_repository)
        {
           _scRepository = scRepository;
            _courseRepository = courseRepository;
            _studentRepository = studentRepository;
            _semester_repository = semester_repository;
        }
        public void ConfirmStudent(StudentOnCourseDTO dto)
        {
           StudentOnCourse sc = new StudentOnCourse();
            sc.CourseId = dto.CourseId;
            sc.Course = _courseRepository.Get(dto.CourseId);
            sc.StudentId = dto.StudentId;
            sc.Student = _studentRepository.Get(dto.StudentId);
            sc.SemesterId = dto.SemesterId;
             sc.Semester = _semester_repository.Get(dto.SemesterId);
            _scRepository.Insert(sc);
           
        }
    }
}
