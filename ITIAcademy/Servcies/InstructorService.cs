using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;

namespace ITIAcademy.Servcies
{
    public class InstructorService : IInstructorService
    {
        private readonly AppDbContext _context;

        public InstructorService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Instructor instructor = _context.Instructors.FirstOrDefault(e => e.Id == id);
            _context.Instructors.Remove(instructor);
            _context.SaveChanges();
        }

        public void Edit(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            _context.SaveChanges();
        }

        public List<Instructor> GetAll()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            return _context.Instructors.FirstOrDefault(x => x.Id == id);
        }
    }
}
