using DZ_Student_Teachers.Domain.Models;
using DZ_Student_Teachers.Domain.Services;
using DZ_Student_Teachers.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Controllers
{
    public class LecturerControllers
    {
        private readonly LecturerService _lecturerService;
        public LecturerControllers(LecturerService lecturerService)
        {
            _lecturerService = lecturerService;
        }
        public IEnumerable<LecturerViewModel> GetAll()
        {
            var lecturers = _lecturerService.GetAll();
            var result = new List<LecturerViewModel>();
            foreach (var lecturer in lecturers)
            {
                result.Add(new LecturerViewModel
                {
                    Id = lecturer.Id,
                    Name = lecturer.Name,
                    Surname = lecturer.Surname,
                    SubjectId = "Unknown"
                });
            }
            return result;
        }
        public LecturerViewModel Create(LecturerPostModel model)
        {
            if (model.Name.Contains(" "))
            {
                return new LecturerViewModel { Name = "Tut Name LecturerViewModel (P_Layer) error", Surname = "Tut Surname LecturerViewModel (P_Layer) error" };
            }
            var lecturerModel = new LecturerModel
            {
                Name = model.Name,
                Surname = model.Surname,
            };
            var createResult = _lecturerService.Create(lecturerModel);
            var result = new LecturerViewModel
            {
                Id = createResult.Id,
                Name = createResult.Name,
                Surname = createResult.Surname,
            };
            return result;
        }
    }
}
