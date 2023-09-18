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
                FirstName = "Nahida",
                LastName = "Kusanali",
                Rank = Rank.AssistantProfessor,
                IsTenured = IsTenured.Permanent,
                HiringDate = DateOnly.Parse("03/11/2022")
            },
            new Instructor()
            {
                Id = 4,
                FirstName = "Furina",
                LastName = "Focalors",
                Rank = Rank.AssociateProfessor,
                IsTenured = IsTenured.Probationary,
                HiringDate = DateOnly.Parse("01/12/2023")
            },

        };
        public IActionResult IndexInstructor()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetailInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(it => it.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);

            return View("IndexInstructor", InstructorList);
        }


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(it => it.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorUpdate)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(it => it.Id == instructorUpdate.Id);
            if (instructor != null)
            {
                instructor.Id = instructorUpdate.Id;
                instructor.FirstName = instructorUpdate.FirstName; 
                instructor.LastName = instructorUpdate.LastName;
                instructor.IsTenured = instructorUpdate.IsTenured;
                instructor.Rank = instructorUpdate.Rank;
                instructor.HiringDate = instructorUpdate.HiringDate;

            }
            return View("IndexInstructor", InstructorList);
        }


    }
}
