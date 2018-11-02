using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Bussiness.Services.Interfaces
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        T GetById(Guid Id);
        void AddOrUpd(T obj);
    }
}
