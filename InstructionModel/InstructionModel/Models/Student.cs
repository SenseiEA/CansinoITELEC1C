using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public DateOnly DateEnrolled { get; set; }

        public Course Course { get; set; }
       
    }
}
