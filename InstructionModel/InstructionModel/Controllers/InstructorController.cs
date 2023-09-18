using Microsoft.AspNetCore.Mvc;
using InstructionModel.Models;

namespace InstructionModel.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
        {
            new Instructor()
            {
                Id = 1,
                FirstName = "Noel",
                LastName = "Cansino",
                Rank = Rank.Professor,
                IsTenured = IsTenured.Permanent,
                HiringDate = DateOnly.Parse("28/09/2020")
            },
            new Instructor()
            {
                Id = 2,
                FirstName = "Ayaka",
                LastName = "Kamisato",
                Rank = Rank.AssistantProfessor,
                IsTenured = IsTenured.Permanent,
                HiringDate = DateOnly.Parse("17/07/2021")
            },
            new Instructor()
            {
                Id = 3,
                FirstName = "Zhong",
                LastName = "Li",
                Rank = Rank.AssociateProfessor,
                IsTenured = IsTenured.Permanent,
                HiringDate = DateOnly.Parse("01/12/2020")
            },
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? student = InstructorList.FirstOrDefault(st => st.Id == id);
            if (student != null)
            {
                return View(student);
            }

            return View();
        }


    }
}
