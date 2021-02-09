using DZ_Student_Teachers.Data.Models;
using DZ_Student_Teachers.Data.Repositories.Interfaces;
using DZ_Student_Teachers.Domain.Models;
using DZ_Student_Teachers.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentsRepository _studentsRepository;
        public StudentService(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }
        public StudentModel Create(StudentModel model)
        {
            if (int.TryParse(model.Name, out int res))
            {
                return new StudentModel { Name = "Tut Name (BL) error", Surname = "Tut Surname (BL) error" };
            }
            var student = new Students
            {
                Name = model.Name,
                Surname = model.Surname,
            };
            //_studentsRepository.Create(student);
            model.Id = student.Id;
            return model;
        }
        public IEnumerable<StudentModel> GetAll()
        {
            var students = _studentsRepository.GetAll();
            var result = new List<StudentModel>();
            foreach (var student in students)
            {
                result.Add(new StudentModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    Surname = student.Surname,
                });

            }
            return result;
        }
    }
}
