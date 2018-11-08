using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tp.Entity.Tp.Entity.Models;

namespace Presentation.Bussiness.Services.Interfaces
{
    public interface IStudentService
    {
        List<Students> GetAllStudents();
        Student GetStudentById(string Id);
        bool CreateOrUpdate(Student student);
        bool Delete(Student student);
    }
}
