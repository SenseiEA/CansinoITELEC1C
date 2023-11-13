using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructionModel.Models
{ 
    public enum Course
    {
        BSCS, BSIT, BSIS
    }
    
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Display(Name = "Date Enrolled")]
        [DataType(DataType.Date)]
        public DateTime DateEnrolled { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }
       
    }
}
