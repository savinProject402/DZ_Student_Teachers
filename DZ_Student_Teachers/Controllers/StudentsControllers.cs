using DZ_Student_Teachers.Domain.Models;
using DZ_Student_Teachers.Domain.Services;
using DZ_Student_Teachers.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Controllers
{
    public class StudentsControllers
    {
        private readonly StudentService _studentService;
        public StudentsControllers(StudentService studentService)
        {
            _studentService = studentService;
        }
        public IEnumerable<StudentsViewModel> GetAll()
        {
            var students = _studentService.GetAll();
            var result = new List<StudentsViewModel>();
            foreach (var student in students)
            {
                result.Add(new StudentsViewModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    Surname = student.Surname,
                });
            }
            return result;
        }
        public StudentsViewModel Create(StudentsViewModel model)
        {
            if (model.Name.Contains("Name_2"))
            {
                return new StudentsViewModel { Name = "Tut Name LecturerViewModel (P_Layer) error", Surname = "Tut Surname LecturerViewModel (P_Layer) error" };
            }
            var studentModel = new StudentModel
            {
                Name = model.Name,
                Surname = model.Surname,
            };
            var createResult = _studentService.Create(studentModel);
            var result = new StudentsViewModel
            {
                Id = createResult.Id,
                Name = createResult.Name,
                Surname = createResult.Surname,
            };
            return result;
        }
    }
}
