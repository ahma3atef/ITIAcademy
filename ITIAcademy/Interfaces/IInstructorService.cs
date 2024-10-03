using ITIAcademy.Models;

namespace ITIAcademy.Interfaces
{
    public interface IInstructorService
    {
        public List<Instructor> GetAll();

        public Instructor GetById(int id);

        public void Add(Instructor instructor);

        public void Edit(Instructor instructor);

        public void Delete(int id);
    }
}
