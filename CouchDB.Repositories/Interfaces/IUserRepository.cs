using Presentation.Entities.Models;
using System.Collections.Generic;
using Tp.Entity.Model;

namespace Presentation.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        Users GetUserById(int Id);
        bool CreateOrUpdate(UserDTO user);
        bool Delete(UserDTO user);
    }
}
