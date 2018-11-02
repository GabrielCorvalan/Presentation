using CouchDB.Bussiness.Services.Interfaces;
using CouchDB.Entities.Models;
using CouchDB.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CouchDB.Bussiness.Classes
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository studentRepo;
        public StudentService(IStudentRepository pRepo)
        {
            studentRepo = pRepo;
        }

        public bool CreateOrUpdate(Student student)
        {
            return studentRepo.CreateOrUpdate(student).Result;
        }

        public List<Student> GetAllStudents()
        {
            return studentRepo.GetAllStudents().Result;
        }

        public Student GetStudentById(string Id)
        {
            return studentRepo.GetStudentById(Id).Result;
        }
        public bool Delete(Student student)
        {
            return studentRepo.Delete(student).Result;
        }
    }
}
