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
    public class Studentservice : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public Studentservice(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student CreateNewStudent(Student st)
        {
            return _studentRepository.Insert(st);
        }

        public Student DeleteStudent(Guid id)
        {
          var student = this.GetStudentById(id);
            return _studentRepository.Delete(student);
        }

        public Student GetStudentById(Guid? id)
        {
            var student = _studentRepository.Get(id);
            return student;
        }

        public List<Student> GetStudents()
        {
           return _studentRepository.GetAll().ToList();
        }

        public Student UpdateStudent(Student st)
        {
          return _studentRepository.Update(st);
        }
    }
}
