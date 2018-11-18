using AutoMapper;
using Presentation.Bussiness.Interfaces;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Bussiness.Classes
{
    public class UserService : IUserService
    {
        readonly IUserRepository userRepo;
        readonly IMapper _mapper;
        public UserService(IUserRepository pRepo, IMapper mapper)
        {
            userRepo = pRepo;
            _mapper = mapper;
        }

        public bool CreateOrUpdate(UserDTO user)
        {
            return userRepo.CreateOrUpdate(user);
        }

        public List<UserDTO> GetAllUsers()
        {
            return userRepo.GetAllUsers().Select(m =>
                    _mapper.Map<UserDTO>(m)
                ).ToList(); ;
        }

        public UserDTO GetUserById(int Id)
        {
            return _mapper.Map<UserDTO>(userRepo.GetUserById(Id));
        }
        public bool Delete(UserDTO user)
        {
            return userRepo.Delete(user);
        }
    }
}
