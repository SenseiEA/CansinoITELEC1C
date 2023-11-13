using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructionModel.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public enum IsTenured
    {
        Permanent,
        Probationary
    }
    public class Instructor
    {
        [Required]
        public int Id { get; set; }

        [Display (Name = "First Name")]
        [Required(ErrorMessage= "Please enter your name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is Required")]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Status")]
        public IsTenured IsTenured { get; set; }

        [Required]
        [Display(Name = "Academic Rank")]
        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

    }
}
