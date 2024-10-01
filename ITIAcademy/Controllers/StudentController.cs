using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        AppDbContext context = new AppDbContext();

        // /Student/GetAll
        public IActionResult GetAll()
        {
            List<Student> students = context.Students.ToList();
            return View(students);
        }

        // /Student/GetById/1
        public IActionResult GetById(int id)
        {
            Student student = context.Students.FirstOrDefault(i => i.Id == id);
            return View(student);
        }


        #region InsertNewStudent
        // /Student/GoToAddForm
        public IActionResult GoToAddForm()
        {
            return View();
        }

        public IActionResult SaveFormData(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditStudent
        public IActionResult SaveEditFormData(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }

        // /Student/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            Student student = context.Students.FirstOrDefault(i => i.Id == id);
            return View(student);
        }
        #endregion

        #region DeleteStudent
        public IActionResult Delete(int id)
        {
            Student student = context.Students.FirstOrDefault(e => e.Id == id);
            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("GetAll");
        }
        #endregion
    }


}
