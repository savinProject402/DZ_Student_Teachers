using DZ_Student_Teachers.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Student_Teachers.Data.Repositories.Interfaces
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetAll();
        Students Create(Students model);
    }
}
