using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
