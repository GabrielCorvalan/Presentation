using Presentation.Entities.Models;
using System.Collections.Generic;
using Tp.Entity.Model;

namespace Presentation.Repositories.Interfaces
{
    public interface IPageRepository
    {
        List<Pages> GetAllPages();
        Pages GetPageById(int Id);
        bool CreateOrUpdate(PageDTO page);
        bool Delete(PageDTO page);
    }
}
