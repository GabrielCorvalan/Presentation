using Presentation.Repositories.Interfaces;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Repositories.Repositories
{
    public class BaseRepository
    {
        public MyCouchClient GetCredentials()
        {
            return new MyCouchClient("http://localhost:5984", "presentation");
        }
    }
}
