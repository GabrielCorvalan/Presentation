using Presentation.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tp.Entity.Model;

namespace Presentation.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Students> GetAllStudents();
        Students GetStudentById(int Id);
        Task<bool> CreateOrUpdate(StudentDTO student);
        bool Delete(Students student);
    }
}
