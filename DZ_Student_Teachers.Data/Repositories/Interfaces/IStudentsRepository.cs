using DZ_Student_Teachers.Data.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Data.Repositories.Interfaces
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetAll();
        //Students Create(Students model);
    }
}
