using Microsoft.AspNetCore.Mvc;
using InstructionModel.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using LabActivtity2.Services;

namespace InstructionModel.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;

        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }

        public IActionResult IndexInstructor()
        {
            return View(_fakeData.InstructorList);
        }

        public IActionResult ShowDetailInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(it => it.Id == id);
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
            _fakeData.InstructorList.Add(newInstructor);

            return RedirectToAction("IndexInstructor");
        }


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(it => it.Id == id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorUpdate)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(it => it.Id == instructorUpdate.Id);
            if (instructor != null)
            {
                instructor.Id = instructorUpdate.Id;
                instructor.FirstName = instructorUpdate.FirstName; 
                instructor.LastName = instructorUpdate.LastName;
                instructor.IsTenured = instructorUpdate.IsTenured;
                instructor.Rank = instructorUpdate.Rank;
                instructor.HiringDate = instructorUpdate.HiringDate;

            }
            return RedirectToAction("IndexInstructor");
        }

        [HttpGet]   
        public IActionResult DeleteInstructor(Instructor instructorDelete)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(it => it.Id == instructorDelete.Id);
            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _fakeData.InstructorList.FirstOrDefault(it => it.Id == id);
            if (instructor !=null){
                _fakeData.InstructorList.Remove(instructor);
                return RedirectToAction("IndexInstructor");
            }

            return NotFound();


        }

    }
}
