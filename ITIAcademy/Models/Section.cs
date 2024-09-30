namespace ITIAcademy.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
