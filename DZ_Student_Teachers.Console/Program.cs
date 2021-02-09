using DZ_Student_Teachers.Controllers;
using DZ_Student_Teachers.Data.Repositories;
using DZ_Student_Teachers.Domain.Services;

namespace DZ_Student_Teachers.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentVoid();
            LecturerVoid();
        }
        public static void StudentVoid()
        {
            var repository = new StudentsRepository();
            var services = new StudentService(repository);
            var controller = new StudentsControllers(services);
            var student = controller.GetAll();
        }
        public static void LecturerVoid()
        {
            var repository = new LecturerRepository();
            var services = new LecturerService(repository);
            var controller = new LecturerControllers(services);
            var lecturer = controller.GetAll();
        }
    }
}
