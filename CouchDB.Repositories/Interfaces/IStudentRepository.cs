using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentById(string Id);
        Task<bool> CreateOrUpdate(Student student);
        Task<bool> Delete(Student student);
    }
}
