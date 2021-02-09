using DZ_Student_Teachers.Data.Models;
using DZ_Student_Teachers.Data.Repositories.Interfaces;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Data.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly IList<Students> _students;
        public StudentsRepository()
        {
            _students = new List<Students>();
            for (int i = 0; i < 10; i++)
            {
                _students.Add(new Students
                {
                    Id = i,
                    Name = $"Name_{i}",
                    Surname = $"Surname_{i}" + 1,
                });
            }
        }
        public IEnumerable<Students> GetAll()
        {
            return _students;
        }
    }
}
