using DZ_Student_Teachers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Student_Teachers.Domain.Services.Interfaces
{
   public interface ILecturerService
    {
        IEnumerable<LecturerModel> GetAll();
        LecturerModel Create(LecturerModel model);
    }
}
