using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Section
    {
        [Required(ErrorMessage = "Id is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Section Name is required.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Section Name must be between 4 and 50 characters.")]
        public string? SectionName { get; set; }


        public int? CourseId { get; set; }
        public Course? Course { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public int? ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
