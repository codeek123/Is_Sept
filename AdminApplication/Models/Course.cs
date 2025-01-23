namespace AdminApplication.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public int AavailableSlots { get; set; }
        public virtual ICollection<StudentOnCourse>? AllStudents { get; set; }
    }
}
