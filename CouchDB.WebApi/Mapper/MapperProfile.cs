using AutoMapper;
using Presentation.Entities.Models;
using Tp.Entity.Model;

namespace Presentation.WebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Students, StudentDTO>();
            CreateMap<StudentDTO, Students>();

            CreateMap<Users, UserDTO>();
            CreateMap<UserDTO, Users>();

            CreateMap<Pages, PageDTO>();
            CreateMap<PageDTO, Pages>();
        }
    }
}
