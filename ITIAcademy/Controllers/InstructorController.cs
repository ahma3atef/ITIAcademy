using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
