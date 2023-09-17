using Microsoft.AspNetCore.Mvc;

    namespace ITELEC1C.Models
{
    public class StudentController1 : Controller
    {
        public IActionResult Student()
        {
            //var st = new Student();
            //st.Id = 1;
            //st.FirstName = "Noel";
            //st.LastName = "Cansino";
            //st.Birthday = DateTime.Parse("12/10/2002");

            //return View();
            List<Student> StudentList = new List<Student>();
            {
                new Student()
                {
                    Id = 1,FirstName = "Gab", 
                    LastName="Montano",
                    BirthDay=DateTime.Parse("12/10/2002"),
                    Major = Major.BSIT,
                    Email = "noelangelo.cansino.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Gab",
                    LastName = "Montano",
                    BirthDay = DateTime.Parse("12/10/2002"),
                    Major = Major.BSIT,
                    Email = "noelangelo.cansino.cics@ust.edu.ph"
                },
                                new Student()
                {
                    Id = 3,
                    FirstName = "Gab",
                    LastName = "Montano",
                    BirthDay = DateTime.Parse("12/10/2002"),
                    Major = Major.BSIT,
                    Email = "noelangelo.cansino.cics@ust.edu.ph"
                }
            };

            return View(@)

        }

}
