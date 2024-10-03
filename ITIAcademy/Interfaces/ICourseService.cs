using ITIAcademy.Models;

namespace ITIAcademy.Interfaces
{
    public interface ICourseService
    {
        public List<Course> GetAll();

        public Course GetById(int id);

        public void Add(Course course);

        public void Edit(Course course);

        public void Delete(int id);
    }
}
