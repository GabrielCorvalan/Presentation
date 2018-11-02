//using CouchDB.Entities.Models;
//using CouchDB.Repositories.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CouchDB.Repositories.Repositories
//{
//    public class StudentMockRepository
//    //: BaseRepository<Student>
//    {
//        public List<Student> GetAllStudents()
//        {
//            List<Student> MyStudentMock = new List<Student>
//            {
//                new Student
//                {
//                    Id = new Guid(),
//                    Career = "Programacion",
//                    Name = "Gabriel",
//                    DateCreated = DateTime.Now,
//                    Years = 21,
//                },
//                new Student
//                {
//                    Id = new Guid(),
//                    Career = "Programacion",
//                    Name = "Roberto",
//                    DateCreated = DateTime.Now,
//                    Years = 32,
//                }
//            };
//            return MyStudentMock;
//        }

//        public Student GetStudentById(Guid Id)
//        {
//            return new Student
//            {
//                Id = new Guid(),
//                Career = "Ingenieria Informatica",
//                Name = "Lucio",
//                DateCreated = DateTime.Now,
//                Years = 45,
//            };
//        }

//        public void CreateOrUpdate(Student student)
//        {
//            var myVar = "Hello Api's world";
//        }

//    }
//}
