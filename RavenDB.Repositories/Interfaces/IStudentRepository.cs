using CouchDB.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(Guid Id);
        void CreateOrUpdate(Student student);
    }
}
