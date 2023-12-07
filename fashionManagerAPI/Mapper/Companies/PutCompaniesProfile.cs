using AutoMapper;

using fashionManager.Dto.Companies.Request;
using fashionManager.Models;

namespace fashionManagerAPI.Mapper.Companies
{
    public class PutCompaniesProfile : Profile
    {
        public PutCompaniesProfile()
        {
            CreateMap<PutCompanies, Company>().ReverseMap();
        }
    }
}