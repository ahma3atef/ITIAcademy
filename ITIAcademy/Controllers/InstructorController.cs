using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        AppDbContext context = new AppDbContext();

        // /Instructor/GetAll
        public IActionResult GetAll()
        {
            List<Instructor> instructors = context.Instructors.ToList();
            return View(instructors);
        }

        // /Instructor/GetById/1
        public IActionResult GetById(int id)
        {
           Instructor instructor = context.Instructors.FirstOrDefault(i=>i.Id==id);
            return View(instructor);
        }


        #region InsertNewInstructor
        // /instructor/GoToAddForm
        public IActionResult GoToAddForm()
        {
            return View();
        }

        public IActionResult SaveFormData(Instructor instructor)
        {
            context.Instructors.Add(instructor);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditInstructor
        public IActionResult SaveEditFormData(Instructor instructor)
        {
            context.Instructors.Update(instructor);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        // /Instructor/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
          Instructor instructor = context.Instructors.FirstOrDefault(i => i.Id == id);
          return View(instructor);
        }
        #endregion

        #region DeleteInstructor
        public IActionResult Delete(int id)
        {
            Instructor instructor = context.Instructors.FirstOrDefault(e => e.Id == id);
            context.Instructors.Remove(instructor);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
