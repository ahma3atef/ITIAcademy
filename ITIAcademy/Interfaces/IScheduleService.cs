using ITIAcademy.Models;

namespace ITIAcademy.Interfaces
{
    public interface IScheduleService
    {
        public List<Schedule> GetAll();

        public Schedule GetById(int id);

        public void Add(Schedule schedule);

        public void Edit(Schedule schedule);

        public void Delete(int id);
    }
}
