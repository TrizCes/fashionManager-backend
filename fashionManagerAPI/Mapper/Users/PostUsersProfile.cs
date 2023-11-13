using AutoMapper;
using fashionManager.Dto.Users.Request;

namespace fashionManagerAPI.Mapper.Users
{
    public class PostUsersProfile : Profile
    {
        public PostUsersProfile()
        {
            CreateMap<PostUsers, Users>().ReverseMap();
        }
    }
}