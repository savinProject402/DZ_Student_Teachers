using DZ_Student_Teachers.Domain.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Domain.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetAll();
        StudentModel Create(StudentModel model);
    }
}
