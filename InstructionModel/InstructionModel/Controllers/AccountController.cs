using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using LabActivtity2.Data;

namespace LabActivtity2.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        public AccountController(SignInManager<User>signInManager)
        {
            _signInManager = signInManager;
        }
        //GET : /<controller>/
        public IActionResult login()
        {
            return View();
        }
    }
}
