using System;
using InstructionModel.Models;
namespace LabActivtity2.Services
{
    public interface IMyFakeDataService
    {
        List<Instructor> InstructorList { get; }

        List<Student> StudentList { get; }

    }


}
