using Domain.Domain_Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ISemesterService
    {
        public List<Semester> GetSemesters();
        public Semester GetSemesterById(Guid? id);
        public Semester CreateNewSemester(Semester s);
        public Semester UpdateSemester(Semester s);
        public Semester DeleteSemester(Guid id);
    }
}
