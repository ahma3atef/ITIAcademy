using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class SectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        AppDbContext context = new AppDbContext();

        // /Section/GetAll
        public IActionResult GetAll()
        {
            List<Section> section = context.Sections.ToList();
            return View(section);
        }
        // /Section/GetById/1
        public IActionResult GetById(int id)
        {
            Section Section = context.Sections.FirstOrDefault(c => c.Id == id);
            return View(Section);
        }


        #region InsertNewSection
        // /Section/GoToAddForm
        public IActionResult GoToAddForm()
        {
            List<Course> courses = context.Courses.ToList();
            ViewData["Courses"] = courses;
            List<Schedule> schedules = context.Schedules.ToList();
            ViewData["Schedules"] = schedules;
            List<Instructor> instructors = context.Instructors.ToList();
            ViewData["Instructors"] = instructors;
            return View();
        }

        public IActionResult SaveFormData(Section Section)
        {
            context.Sections.Add(Section);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditCourse
        public IActionResult SaveEditFormData(Section section)
        {
            context.Sections.Update(section);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        // /Section/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            Section section = context.Sections.FirstOrDefault(e => e.Id == id);

            List<Course> courses = context.Courses.ToList();
            ViewData["Courses"] = courses;
            List<Schedule> schedules = context.Schedules.ToList();
            ViewData["Schedules"] = schedules;
            List<Instructor> instructors = context.Instructors.ToList();
            ViewData["Instructors"] = instructors;

            return View(section);
        }
        #endregion

        #region DeleteScetion
        public IActionResult Delete(int id)
        {
            Section section = context.Sections.FirstOrDefault(e => e.Id == id);
            context.Sections.Remove(section);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
