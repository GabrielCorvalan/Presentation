using AutoMapper;
using Presentation.Bussiness.Services.Interfaces;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Tp.Entity.Model;

namespace Presentation.Bussiness.Classes
{
    public class StudentService : IStudentService
    {
        readonly IStudentRepository studentRepo;
        readonly IMapper _mapper;
        public StudentService(IStudentRepository pRepo, IMapper mapper)
        {
            studentRepo = pRepo;
            _mapper = mapper;
        }

        public bool CreateOrUpdate(StudentDTO student)
        {
            return studentRepo.CreateOrUpdate(student).Result;
        }

        public List<StudentDTO> GetAllStudents()
        {
            return studentRepo.GetAllStudents().Select(m =>
                    _mapper.Map<StudentDTO>(m)
                ).ToList(); ;
        }

        public StudentDTO GetStudentById(int Id)
        {
            return _mapper.Map<StudentDTO>(studentRepo.GetStudentById(Id));
        }
        public bool Delete(StudentDTO student)
        {
            return studentRepo.Delete(_mapper.Map<Students>(student));
        }
    }
}
