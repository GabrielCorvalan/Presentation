using CouchDB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Bussiness.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudentById(Guid Id);
        void CreateOrUpdate(Student student);
    }
}
