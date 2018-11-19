using AutoMapper;
using Presentation.Bussiness.Interfaces;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;

namespace Presentation.Bussiness.Classes
{
    public class LoginService : ILoginService
    {
        readonly IUserRepository userRepo;
        readonly IMapper _mapper;
        public LoginService(IUserRepository pRepo, IMapper mapper)
        {
            userRepo = pRepo;
            _mapper = mapper;
        }
        public UserDTO GetUserLogin(string username, string password)
        {
            return _mapper.Map<UserDTO>(userRepo.GetUserLogin(username,password));
        }
    }
}
