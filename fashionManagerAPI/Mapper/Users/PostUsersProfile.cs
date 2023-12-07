using AutoMapper;
using fashionManager.Dto.Users.Request;
using fashionManager.Models;

namespace fashionManagerAPI.Mapper.Users
{
    public class PostUsersProfile : Profile
    {
        public PostUsersProfile()
        {
            CreateMap<PostUsers, User>().ReverseMap();
        }
    }
}