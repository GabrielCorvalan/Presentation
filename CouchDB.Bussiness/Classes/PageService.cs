using AutoMapper;
using Presentation.Bussiness.Interfaces;
using Presentation.Entities.Models;
using Presentation.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Presentation.Bussiness.Classes
{
    public class PageService : IPageService
    {
        readonly IPageRepository pageRepo;
        readonly IMapper _mapper;
        public PageService(IPageRepository pRepo, IMapper mapper)
        {
            pageRepo = pRepo;
            _mapper = mapper;
        }

        public bool CreateOrUpdate(PageDTO page)
        {
            return pageRepo.CreateOrUpdate(page);
        }

        public List<PageDTO> GetAllPages()
        {
            return pageRepo.GetAllPages().Select(m =>
                    _mapper.Map<PageDTO>(m)
                ).ToList(); ;
        }

        public PageDTO GetPageById(int Id)
        {
            return _mapper.Map<PageDTO>(pageRepo.GetPageById(Id));
        }
        public bool Delete(PageDTO page)
        {
            return pageRepo.Delete(page);
        }
    }
}
