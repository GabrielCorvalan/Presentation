using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tp.Entity.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Presentation.Repositories.Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        private readonly IMapper _mapper;
        public StudentRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<Students> GetAllStudents()
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Students.AsNoTracking().ToList();
            }
        }
        public Students GetStudentById(int Id)
        {
            using (var ctx = new SysacadFRGPContext())
            {
                return ctx.Students.AsNoTracking().Where(s => s.Id.Equals(Id)).FirstOrDefault();
            }
        }
        public bool Delete(Students student)
        {
            using (var ctx = new SysacadFRGPContext())
            {
                ctx.Students.Remove(student);
                ctx.SaveChanges();
                return true;
            }
        }
        public async Task<bool> CreateOrUpdate(StudentDTO student)
        {
            try
            {
                using (var db = GetCredentials())
                {
                    if (student.Id > 0)
                    {
                        var response = await db.Entities.PutAsync(student);
                        return response.IsSuccess;
                    }
                    else
                    {
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
