using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;

namespace ITIAcademy.Servcies
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = _context.Students.FirstOrDefault(e => e.Id == id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public void Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
