using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        T GetById(Guid Id);
        void AddOrUpd(T obj);
    }
}
