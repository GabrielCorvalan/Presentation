using Presentation.Entities.Models;
using System.Collections.Generic;

namespace Presentation.Bussiness.Interfaces
{
    public interface IPageService
    {
        List<PageDTO> GetAllPages();
        PageDTO GetPageById(int Id);
        bool CreateOrUpdate(PageDTO page);
        bool Delete(PageDTO page);
    }
}
