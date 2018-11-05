using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using MyCouch;
using MyCouch.Requests;
using MyCouch.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Repositories.Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public async Task<List<Student>> GetAllStudents()
        {
            var students = new List<Student>();
            using (var db = GetCredentials())
            {

                var query = new QueryViewRequest("GetAllStudents", "AllStudents")
                {
                    IncludeDocs = true
                };
                var response = await db.Views.QueryAsync<Student>(query);

                foreach (var item in response.Rows)
                {
                    students.Add(JsonConvert.DeserializeObject<Student>(item.IncludedDoc));
                }

                return students;
            }
        }
        public async Task<Student> GetStudentById(string Id)
        {
            using (var db = GetCredentials())
            {
                var response = await db.Entities.GetAsync<Student>(Id);

                return response.Content;
            }
        }
        public async Task<bool> Delete(Student student)
        {
            using(var db = GetCredentials())
            {
                var response = await db.Entities.DeleteAsync(student);

                return response.IsSuccess;
            }
        }
        public async Task<bool> CreateOrUpdate(Student student)
        {
            try
            {
                using (var db = GetCredentials())
                {
                    if (!string.IsNullOrEmpty(student._id) && !string.IsNullOrEmpty(student._rev))
                    {
                        var response = await db.Entities.PutAsync(student);
                        return response.IsSuccess;
                    }
                    else
                    {
                        student._id = null;
                        student._rev = null;
                        var response = await db.Entities.PostAsync(student);
                        return response.IsSuccess;
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
