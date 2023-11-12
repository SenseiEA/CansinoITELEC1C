using Microsoft.AspNetCore.Mvc;
using InstructionModel.Models;
using LabActivtity2.Services;


namespace InstructionModel.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _fakeData;

        public StudentController (IMyFakeDataService fakeData)
        {   
            _fakeData = fakeData;
        }

        public IActionResult IndexStudent()
        {
            return View(_fakeData.StudentList);
        }

        public IActionResult ShowDetailStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);
            if (student != null)
            {
                return View(student);
            }

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _fakeData.StudentList.Add(newStudent);

            return RedirectToAction("IndexStudent");
        }


        [HttpGet]
        public IActionResult EditStudent(int id)
        {
             Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);
                if (student != null)
                {
                    return View(student);
                }

                return NotFound();

        }
        [HttpPost]
        public IActionResult EditStudent(Student studentUpdate)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == studentUpdate.Id);
            if(student != null)
            {
                student.Id = studentUpdate.Id;
                student.Name = studentUpdate.Name;
                student.Course = studentUpdate.Course;
                student.DateEnrolled = studentUpdate.DateEnrolled;

            }
            return RedirectToAction("IndexStudent");
        }

        [HttpGet]
        public IActionResult DeleteStudent(Student studentDelete)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(it => it.Id == studentDelete.Id);
            if (student != null)
            {
                return View(student);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _fakeData.StudentList.FirstOrDefault(it => it.Id == id);
            if (student != null)
            {
                _fakeData.StudentList.Remove(student);
                return RedirectToAction("IndexStudent");
            }

            return NotFound();


        }



        /*
                private List<Student> students = new List<Student>();// Replace with your actual repository or data access mechanism.

                public StudentController(StudentList List<Student>)
                {
                    _studentRepository = studentRepository;
                }

                public IActionResult EditStudent(int id)
                {
                    // Retrieve the student from your data source by ID
                    var student = _studentRepository.GetStudentById(id);

                    if (student == null)
                    {
                        // Handle the case where the student is not found
                        return NotFound();
                    }

                    // Pass the student to the view
                    return View(student);
                }

                [HttpPost]
                public IActionResult EditStudent(Student student)
                {
                    // Validate and update the student's details in your data source
                    if (ModelState.IsValid)
                    {
                        _studentRepository.UpdateStudent(student);
                        // Redirect to a different page or action after updating
                        return RedirectToAction("Index");
                    }

                    // If validation fails, return the view with error messages
                    return View(student);
                }
            }*/

    }
}
