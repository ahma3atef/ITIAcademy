using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;

namespace ITIAcademy.Servcies
{
    public class SectionService : ISectionService
    {
        private readonly AppDbContext _context;

        public SectionService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Section section)
        {
            _context.Sections.Add(section);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Section section = _context.Sections.FirstOrDefault(e => e.Id == id);
            _context.Sections.Remove(section);
            _context.SaveChanges();
        }

        public void Edit(Section section)
        {
            _context.Sections.Update(section);
            _context.SaveChanges();
        }

        public List<Section> GetAll()
        {
            return _context.Sections.ToList();
        }

        public Section GetById(int id)
        {
            return _context.Sections.FirstOrDefault(x => x.Id == id);
        }
    }
}
