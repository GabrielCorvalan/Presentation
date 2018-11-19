using Presentation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Bussiness.Interfaces
{
    public interface ILoginService
    {
        UserDTO GetUserLogin(string userName, string password);
    }
}
