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
    public class SemesterService : ISemesterService
    {

        private readonly IRepository<Semester> _semesterRepository;

        public SemesterService(IRepository<Semester> semesterRepository)
        {
            _semesterRepository = semesterRepository;
        }
        public Semester CreateNewSemester(Semester s)
        {
            return _semesterRepository.Insert(s);
        }

        public Semester DeleteSemester(Guid id)
        {
            var semester = this.GetSemesterById(id);
            return _semesterRepository.Delete(semester);
        }

        public Semester GetSemesterById(Guid? id)
        {
            var semester = _semesterRepository.Get(id);
            return semester;
        }

        public List<Semester> GetSemesters()
        {
          return _semesterRepository.GetAll().ToList();
        }

        public Semester UpdateSemester(Semester s)
        {
            return _semesterRepository.Update(s);
        }
    }
}
