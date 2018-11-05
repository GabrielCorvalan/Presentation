using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Bussiness.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(string Id);
        bool CreateOrUpdate(Student student);
        bool Delete(Student student);
    }
}
