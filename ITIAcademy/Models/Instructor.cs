using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Instructor
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
        
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
