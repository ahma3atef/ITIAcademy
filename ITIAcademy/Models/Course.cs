using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Id is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Course Name is required.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Course Name must be between 4 and 100 characters.")]
        public string? CourseName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
