using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using InstructionModel.Models;

namespace LabActivtity2.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }     
        public DbSet<Instructor> Instructors { get; set; }

        //constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
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
                );

            modelBuilder.Entity<Instructor>().HasData(
                 new Instructor()
                 {
                     Id = 1,
                     FirstName = "Noel",
                     LastName = "Cansino",
                     Rank = Rank.Professor,
                     IsTenured = IsTenured.Permanent,
                     HiringDate = DateTime.Parse("28/09/2020")
                 },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Ayaka",
                    LastName = "Kamisato",
                    Rank = Rank.AssistantProfessor,
                    IsTenured = IsTenured.Permanent,
                    HiringDate = DateTime.Parse("17/07/2021")
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Nahida",
                    LastName = "Kusanali",
                    Rank = Rank.AssistantProfessor,
                    IsTenured = IsTenured.Permanent,
                    HiringDate = DateTime.Parse("03/11/2022")
                },
                new Instructor()
                {
                    Id = 4,
                    FirstName = "Furina",
                    LastName = "de Fontaine",
                    Rank = Rank.AssociateProfessor,
                    IsTenured = IsTenured.Probationary,
                    HiringDate = DateTime.Parse("08/11/2023")
                }
                );
        }
    }
}
