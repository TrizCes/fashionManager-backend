using AutoMapper;
using fashionManager.Dto.Companies.Request;
using fashionManager.Models;

namespace fashionManagerAPI.Mapper.Companies
{
    public class PostCompaniesProfile : Profile
    {
        public PostCompaniesProfile()
        {
            CreateMap<PostCompanies, Company>().ReverseMap();
        }
    }
}