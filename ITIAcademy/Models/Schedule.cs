using System.ComponentModel.DataAnnotations;

namespace ITIAcademy.Models
{
    public class Schedule
    {
        [Required(ErrorMessage = "Id is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Id must be a positive number.")]
        public int Id { get; set; }

        public string Title {  get; set; }

        public bool SUN { get; set; }
        public bool MON { get; set; }
        public bool TUE { get; set; }
        public bool WED { get; set; }
        public bool THU { get; set; }
        public bool FRI { get; set; }
        public bool SAT { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
