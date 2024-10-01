using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        AppDbContext context = new AppDbContext(); 
        
        // /Course/GetAll
        public IActionResult GetAll()
        {
            List<Course> courses = context.Courses.ToList();
            return View(courses);
        }

        // /Course/GetById/1
        public IActionResult GetById(int id) 
        {
            Course course = context.Courses.FirstOrDefault(c => c.Id == id);
            
            return View(course);
        }


        #region InsertNewCourse
        // /Course/GoToAddForm
        public IActionResult GoToAddForm()
        {
            return View();
        }

        public IActionResult SaveFormData(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditCourse
        public IActionResult SaveEditFormData(Course course)
        {
            context.Courses.Update(course);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        // /Course/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            Course course = context.Courses.FirstOrDefault(e => e.Id == id);
            return View(course);
        }
        #endregion

        #region DeleteCourse
        public IActionResult Delete(int id)
        {
            Course course = context.Courses.FirstOrDefault(e => e.Id == id);
            context.Courses.Remove(course);
            context.SaveChanges();  
            return RedirectToAction("GetAll");
        }
        #endregion

    }
}
