using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
