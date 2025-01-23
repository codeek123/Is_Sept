namespace AdminApplication.Models
{
    public class Semester
    {
        public Guid Id { get; set; }
        public string? SemesterCode { get; set; }
        public string? SemesterName { get; set; }
        public virtual ICollection<StudentOnCourse>? StudentOnCourses { get; set; }
    }
}
