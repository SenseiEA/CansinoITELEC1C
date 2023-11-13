using Microsoft.AspNetCore.Mvc;
using InstructionModel.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using LabActivtity2.Services;
using LabActivtity2.Data;

namespace InstructionModel.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult IndexInstructor()
        {
            return View(_dbContext.Instructors);
        }

        public IActionResult ShowDetailInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(it => it.Id == id);
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
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();

            return RedirectToAction("IndexInstructor");
        }


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(it => it.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorUpdate)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(it => it.Id == instructorUpdate.Id);
            if (instructor != null)
            {
                instructor.Id = instructorUpdate.Id;
                instructor.FirstName = instructorUpdate.FirstName; 
                instructor.LastName = instructorUpdate.LastName;
                instructor.IsTenured = instructorUpdate.IsTenured;
                instructor.Rank = instructorUpdate.Rank;
                instructor.HiringDate = instructorUpdate.HiringDate;
                _dbContext.SaveChanges();

            }
            return RedirectToAction("IndexInstructor");
        }

        [HttpGet]   
        public IActionResult DeleteInstructor(Instructor instructorDelete)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(it => it.Id == instructorDelete.Id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(it => it.Id == id);
            if (instructor !=null){
                _dbContext.Instructors.Remove(instructor);
                _dbContext.SaveChanges();
                return RedirectToAction("IndexInstructor");
            }

            return NotFound();


        }

    }
}
