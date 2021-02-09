using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_Student_Teachers.Data.Models;
using DZ_Student_Teachers.Data.Repositories.Interfaces;
using DZ_Student_Teachers.Domain.Models;
using DZ_Student_Teachers.Domain.Services.Interfaces;

namespace DZ_Student_Teachers.Domain.Services
{
   public class StudentService : IStudentService
    {
        private readonly IStudentsRepository _studentsRepository;
        public StudentService (IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }
        public StudentModel Create(StudentModel model)
        {
            if (int.TryParse(model.Name, out int res))
            {
                return new StudentModel { Name = "Tut Name (BL) error", Surname = "Tut Surname (BL) error" };
            }
            var student = new Student
            {
                Name = model.Name,
                Surname = model.Surname,
            };
            _studentsRepository.Create(student);
            model.Id = student.Id;
            return model;

        }
    }
}
