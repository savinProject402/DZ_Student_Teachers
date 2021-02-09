using DZ_Student_Teachers.Domain.Models;
using System.Collections.Generic;

namespace DZ_Student_Teachers.Domain.Services.Interfaces
{
    public interface ILecturerService
    {
        IEnumerable<LecturerModel> GetAll();
        LecturerModel Create(LecturerModel model);
    }
}
