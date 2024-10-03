using ITIAcademy.Models;

namespace ITIAcademy.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetAll();

        public Student GetById(int id);

        public void Add(Student student);

        public void Edit(Student student);

        public void Delete(int id);
    }
}
