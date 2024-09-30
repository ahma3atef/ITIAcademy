namespace ITIAcademy.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
