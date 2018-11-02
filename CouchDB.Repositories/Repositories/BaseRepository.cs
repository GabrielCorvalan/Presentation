using CouchDB.Repositories.Interfaces;
using MyCouch;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Repositories.Repositories
{
    public class BaseRepository
    {
        public MyCouchClient GetCredentials()
        {
            return new MyCouchClient("http://localhost:5984", "presentation");
        }
    }
}
