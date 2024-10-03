using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ISectionService _sectionService;

        public StudentController(IStudentService studentService, ISectionService sectionService)
        {
            _studentService = studentService;
            _sectionService = sectionService;
        }
    
        // /Student/GetAll
        public IActionResult GetAll()
        {
            return View(_studentService.GetAll());
        }

        // /Student/GetById/1
        public IActionResult GetById(int id)
        {
            return View(_studentService.GetById(id));
        }

        #region InsertNewStudent
        // /Student/GoToAddForm
        public IActionResult GoToAddForm()
        {
            ViewData["Sections"] = _sectionService.GetAll();
            return View();
        }

        public IActionResult SaveFormData(Student student)
        {
            _studentService.Add(student);
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditStudent
        public IActionResult SaveEditFormData(Student student)
        {
            _studentService.Edit(student);
            return RedirectToAction("GetAll");
        }

        // /Student/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            ViewData["Sections"] = _sectionService.GetAll();
            return View(_studentService.GetById(id));
        }
        #endregion

        #region DeleteStudent
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
