using Microsoft.AspNetCore.Mvc;
using InstructionModel.Models;

namespace InstructionModel.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
        {
            new Student()
            {
                Id = 1,
                Name = "Heizou Shikanoin",
                Course = Course.BSIS,
                DateEnrolled = DateTime.Parse("13/07/2022")
            },
            new Student()
            {
                Id = 2,
                Name = "Ayaka Kamisato",
                Course = Course.BSCS,
                DateEnrolled = DateTime.Parse("17/07/2021")
            },
            new Student()
            {
                Id = 3,
                Name = "Yoimiya Naganohara",
                Course = Course.BSIS,
                DateEnrolled = DateTime.Parse("10/08/2021")
            },
            new Student()
            {
                Id = 4,
                Name = "Kokomi Sangonomiya",
                Course = Course.BSIT,
                DateEnrolled = DateTime.Parse("17/07/2021")
            },
            new Student()
            {
                Id = 5,
                Name = "Itto Arataki",
                Course = Course.BSIS,
                DateEnrolled = DateTime.Parse("14/12/2021")
            }
        };
        public IActionResult IndexStudent()
        {
            return View(StudentList);
        }

        public IActionResult ShowDetailStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
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
            StudentList.Add(newStudent);

            return View("IndexStudent", StudentList);
        }


        [HttpGet]
        public IActionResult EditStudent(int id)
        {
             Student? student = StudentList.FirstOrDefault(st => st.Id == id);
                if (student != null)
                {
                    return View(student);
                }

                return NotFound();

        }
        [HttpPost]
        public IActionResult EditStudent(Student studentUpdate)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentUpdate.Id);
            if(student != null)
            {
                student.Id = studentUpdate.Id;
                student.Name = studentUpdate.Name;
                student.Course = studentUpdate.Course;
                student.DateEnrolled = studentUpdate.DateEnrolled;

            }
            return View("IndexStudent", StudentList);
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
