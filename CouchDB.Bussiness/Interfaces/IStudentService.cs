using Presentation.Entities.Models;
using System.Collections.Generic;

namespace Presentation.Bussiness.Services.Interfaces
{
    public interface IStudentService
    {
        List<StudentDTO> GetAllStudents();
        StudentDTO GetStudentById(int Id);
        bool CreateOrUpdate(StudentDTO student);
        bool Delete(StudentDTO student);
    }
}
