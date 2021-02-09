using DZ_Student_Teachers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Student_Teachers.Domain.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetAll();
        StudentModel Create(StudentModel model);
    }
}
