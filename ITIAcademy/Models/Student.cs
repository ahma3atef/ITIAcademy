namespace ITIAcademy.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
