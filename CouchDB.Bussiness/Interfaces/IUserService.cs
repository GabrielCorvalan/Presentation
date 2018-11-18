using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Bussiness.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> GetAllUsers();
        UserDTO GetUserById(int Id);
        bool CreateOrUpdate(UserDTO user);
        bool Delete(UserDTO user);
    }
}
