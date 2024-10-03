using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;

namespace ITIAcademy.Servcies
{
    public class ScheduleService : IScheduleService
    {
        private readonly AppDbContext _context;

        public ScheduleService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Schedule schedule = _context.Schedules.FirstOrDefault(e => e.Id == id);
            _context.Schedules.Remove(schedule);
            _context.SaveChanges();
        }

        public void Edit(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            _context.SaveChanges();
        }

        public List<Schedule> GetAll()
        {
            return _context.Schedules.ToList();
        }

        public Schedule GetById(int id)
        {
            return _context.Schedules.FirstOrDefault(x => x.Id == id);
        }
    }
}
