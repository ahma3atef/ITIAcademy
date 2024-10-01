using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        AppDbContext context = new AppDbContext();

        public IActionResult GetAll()
        {
            List<Schedule> schedules = context.Schedules.ToList();
            return View(schedules);
        }

        // /Course/GetById/1
        public IActionResult GetById(int id)
        {
            Schedule Schedule = context.Schedules.FirstOrDefault(c => c.Id == id);

            Dictionary<string, bool> days = new Dictionary<string, bool>()
            {
                {"SUN", Schedule.SUN },
                {"MON", Schedule.MON },
                {"TUE", Schedule.TUE },
                {"WED", Schedule.WED },
                {"THU", Schedule.THU },
                {"FRI", Schedule.FRI },
                {"SAT", Schedule.SAT }
            };
            ViewData["Days"] = days;

            return View(Schedule);
        }

        #region InsertNewSchedule
        // /Schedule/GoToAddForm
        public IActionResult GoToAddForm()
        {
            List<Schedule> schedules = context.Schedules.ToList();
            ViewData["schedules"] = schedules;
            return View();
        }

        public IActionResult SaveFormData(Schedule schedule)
        {
            context.Schedules.Add(schedule);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditSchedule
        public IActionResult SaveEditFormData(Schedule schedule)
        {
            context.Schedules.Update(schedule);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        // /Schedule/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            Schedule schedule = context.Schedules.FirstOrDefault(e => e.Id == id);
            List<Schedule> schedules = context.Schedules.ToList();
            ViewData["schedules"] = schedules;
            return View(schedule);
        }
        #endregion

        #region DeleteSchedule
        public IActionResult Delete(int id)
        {
            Schedule Schedule = context.Schedules.FirstOrDefault(e => e.Id == id);
            context.Schedules.Remove(Schedule);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
