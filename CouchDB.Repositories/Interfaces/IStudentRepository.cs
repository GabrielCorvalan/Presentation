using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tp.Entity.Tp.Entity.Models;

namespace Presentation.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Students> GetAllStudents();
        Task<Student> GetStudentById(string Id);
        Task<bool> CreateOrUpdate(Student student);
        Task<bool> Delete(Student student);
    }
}
