using DZ_Student_Teachers.Data.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Data.Repositories.Interfaces
{
    public interface ILecturerRepository
    {
        IEnumerable<Lecturer> GetAll();
        //Lecturer Create(Lecturer model);
    }
}
