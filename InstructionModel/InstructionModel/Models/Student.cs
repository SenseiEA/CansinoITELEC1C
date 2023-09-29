using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace InstructionModel.Models
{ 
    public enum Course
    {
        BSCS, BSIT, BSIS
    }

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly DateEnrolled { get; set; }

        public Course Course { get; set; }
       
    }
}
