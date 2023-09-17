using Microsoft.AspNetCore.Mvc;

namespace MachineProblem1.Models
{
    public class Student : Controller
    {
        public IActionResult TenuredTest()
        {
            return View();
        }
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
        public Major Major { get; set; }

    }
}
