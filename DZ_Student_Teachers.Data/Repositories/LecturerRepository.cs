using DZ_Student_Teachers.Data.Models;
using DZ_Student_Teachers.Data.Repositories.Interfaces;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Data.Repositories
{
    public class LecturerRepository : ILecturerRepository
    {
        private readonly IList<Lecturer> _lecturer;
        public LecturerRepository()
        {
            _lecturer = new List<Lecturer>();
            for (int i = 0; i < 10; i++)
            {
                _lecturer.Add(new Lecturer
                {
                    Id = i,
                    Name = $"Name_{i}",
                    Surname = $"Surname_{i}" + 1,
                });
            }
        }
        public IEnumerable<Lecturer> GetAll()
        {
            return _lecturer;
        }
    }
}
