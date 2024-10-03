using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class SectionController : Controller
    {
        private readonly ISectionService _sectionService;
        private readonly ICourseService _courseService;
        private readonly IScheduleService _scheduleService;
        private readonly IInstructorService _instructorService;

        public SectionController(ISectionService sectionService, ICourseService courseService,
            IScheduleService scheduleService, IInstructorService instructorService)
        {
            _sectionService = sectionService;
            _courseService = courseService;
            _scheduleService = scheduleService;
            _instructorService = instructorService;
        }
        
        // /Section/GetAll
        public IActionResult GetAll()
        {
            return View(_sectionService.GetAll());
        }
        // /Section/GetById/1
        public IActionResult GetById(int id)
        {
            return View(_sectionService.GetById(id));
        }

        #region InsertNewSection
        // /Section/GoToAddForm
        public IActionResult GoToAddForm()
        {
            ViewData["Courses"] = _courseService.GetAll();
            ViewData["Schedules"] = _scheduleService.GetAll();
            ViewData["Instructors"] = _instructorService.GetAll();
            return View();
        }

        public IActionResult SaveFormData(Section Section)
        {
            _sectionService.Add(Section);
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditCourse
        public IActionResult SaveEditFormData(Section section)
        {
            _sectionService.Edit(section);
            return RedirectToAction("GetAll");
        }
        // /Section/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            ViewData["Courses"] = _courseService.GetAll();
            ViewData["Schedules"] = _scheduleService.GetAll();
            ViewData["Instructors"] = _instructorService.GetAll();
            return View(_sectionService.GetById(id));
        }
        #endregion

        #region DeleteScetion
        public IActionResult Delete(int id)
        {
            _sectionService.Delete(id);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
