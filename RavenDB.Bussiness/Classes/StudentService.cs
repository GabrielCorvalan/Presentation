using CouchDB.Bussiness.Services.Interfaces;
using CouchDB.Entities.Models;
using CouchDB.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Bussiness.Classes
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository studentRepo;
        public StudentService(IStudentRepository pRepo)
        {
            studentRepo = pRepo;
        }

        public void CreateOrUpdate(Student student)
        {
            studentRepo.CreateOrUpdate(student);
        }

        public List<Student> GetAllStudents()
        {
            return studentRepo.GetAllStudents();
        }

        public Student GetStudentById(Guid Id)
        {
            return studentRepo.GetStudentById(Id);
        }
    }
}
