using DZ_Student_Teachers.Data.Models;
using DZ_Student_Teachers.Data.Repositories.Interfaces;
using DZ_Student_Teachers.Domain.Models;
using DZ_Student_Teachers.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Domain.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly ILecturerRepository _lecturerRepository;
        public LecturerService(ILecturerRepository lecturerRepository)
        {
            _lecturerRepository = lecturerRepository;
        }
        public LecturerModel Create(LecturerModel model)
        {
            if (int.TryParse(model.Name, out int res))
            {
                return new LecturerModel { Name = "Tut Name (BL) error", Surname = "Tut Surname (BL) error" };
            }
            var lecturer = new Lecturer
            {
                Name = model.Name,
                Surname = model.Surname,
            };
            //_lecturerRepository.Create(lecturer);
            model.Id = lecturer.Id;
            return model;

        }
        public IEnumerable<LecturerModel> GetAll()
        {
            var lecturers = _lecturerRepository.GetAll();
            var result = new List<LecturerModel>();
            foreach (var lecturer in lecturers)
            {
                result.Add(new LecturerModel
                {
                    Id = lecturer.Id,
                    Name = lecturer.Name,
                    Surname = lecturer.Surname,
                });
            }
            return result;
        }
    }
}
