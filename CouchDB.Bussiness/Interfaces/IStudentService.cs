using CouchDB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CouchDB.Bussiness.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(string Id);
        bool CreateOrUpdate(Student student);
        bool Delete(Student student);
    }
}
