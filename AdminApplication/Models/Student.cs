namespace AdminApplication.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string? StudentIndex { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Embg { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual ICollection<StudentOnCourse>? AllCourses { get; set; }
    }
}
