using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Id is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 10 characters.")]
        public string? FName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 10 characters.")]
        public string? LName { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
