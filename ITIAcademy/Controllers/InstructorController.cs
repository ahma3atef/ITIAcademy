using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // /Instructor/GetAll
        public IActionResult GetAll()
        {
            return View(_instructorService.GetAll());
        }

        // /Instructor/GetById/1
        public IActionResult GetById(int id)
        {
            return View(_instructorService.GetById(id));
        }

        #region InsertNewInstructor
        // /instructor/GoToAddForm
        public IActionResult GoToAddForm()
        {
            return View();
        }

        public IActionResult SaveFormData(Instructor instructor)
        {
            _instructorService.Add(instructor);
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditInstructor
        public IActionResult SaveEditFormData(Instructor instructor)
        {
            _instructorService.Edit(instructor);
            return RedirectToAction("GetAll");
        }

        // /Instructor/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            return View(_instructorService.GetById(id));
        }
        #endregion

        #region DeleteInstructor
        public IActionResult Delete(int id)
        {
            _instructorService.Delete(id);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
