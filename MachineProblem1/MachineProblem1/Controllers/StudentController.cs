using Microsoft.AspNetCore.Mvc;

namespace MachineProblem1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult MachineProblem1()
        {
            return View();
        }
        public IActionResult TenuredTest()
        {
            return View();
        }
    }
}
