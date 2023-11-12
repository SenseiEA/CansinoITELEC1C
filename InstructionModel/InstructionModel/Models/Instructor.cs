using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructionModel.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public enum IsTenured
    {
        Permanent, Probationary
    }
    public class Instructor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IsTenured IsTenured { get; set; }

        public Rank Rank { get; set; }

        [NotMapped]
        public DateOnly HiringDate { get; set; }

    }
}
