using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetAll()
        {
            return View(_scheduleService.GetAll());
        }

        // /Course/GetById/1
        public IActionResult GetById(int id)
        {
            Schedule Schedule = _scheduleService.GetById(id);

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
            ViewData["schedules"] = _scheduleService.GetAll();
            return View();
        }

        public IActionResult SaveFormData(Schedule schedule)
        {
            _scheduleService.Add(schedule);
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditSchedule
        public IActionResult SaveEditFormData(Schedule schedule)
        {
            _scheduleService.Add(schedule);
            return RedirectToAction("GetAll");
        }

        // /Schedule/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            ViewData["schedules"] = _scheduleService.GetAll();
            return View(_scheduleService.GetById(id));
        }
        #endregion

        #region DeleteSchedule
        public IActionResult Delete(int id)
        {
            _scheduleService.Delete(id);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
