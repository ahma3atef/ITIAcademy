using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;

namespace ITIAcademy.Servcies
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Course course = _context.Courses.FirstOrDefault(e => e.Id == id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }

        public void Edit(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return _context.Courses.FirstOrDefault(x => x.Id == id);
        }
    }
}
