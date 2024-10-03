using ITIAcademy.Data;
using ITIAcademy.Interfaces;
using ITIAcademy.Models;
using ITIAcademy.Servcies;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        // /Course/GetAll
        public IActionResult GetAll()
        {
            return View(_courseService.GetAll()); //returns list of courses
        }

        // /Course/GetById/1
        public IActionResult GetById(int id) 
        {            
            return View(_courseService.GetById(id)); ////returns course
        }

        #region InsertNewCourse
        // /Course/GoToAddForm
        public IActionResult GoToAddForm()
        {
            return View();
        }

        public IActionResult SaveFormData(Course course)
        {
            _courseService.Add(course);
            return RedirectToAction("GetAll");
        }
        #endregion

        #region EditCourse
        public IActionResult SaveEditFormData(Course course)
        {
            _courseService.Edit(course);
            return RedirectToAction("GetAll");
        }

        // /Course/GoToEditForm/1
        public IActionResult GoToEditForm(int id)
        {
            return View(_courseService.GetById(id));
        }
        #endregion

        #region DeleteCourse
        public IActionResult Delete(int id)
        {
            _courseService.Delete(id);
            return RedirectToAction("GetAll");
        }
        #endregion
    }
}
