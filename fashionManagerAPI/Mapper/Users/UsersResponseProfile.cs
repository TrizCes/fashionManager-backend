﻿using AutoMapper;
using fashionManager.Dto.Users.Response;
using fashionManager.Extensions;
using fashionManager.Models;

namespace fashionManagerAPI.Mapper.Users
{
    public class UsersResponseProfile : Profile
    {
        public UsersResponseProfile()
        {
            CreateMap<User, UsersResponse>()
                .ForMember(dest => dest.Id, src => src.MapFrom(s => s.Id))
                .ForMember(dest => dest.CompanyId, src => src.MapFrom(s => s.CompanyId))
                .ForMember(dest => dest.CompanyName, src => src.MapFrom(s => s.Company.Name))
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.Email, src => src.MapFrom(s => s.Email))
                .ForMember(dest => dest.Role, src => src.MapFrom(s => s.Role.GetEnumDescription()))
                .ForMember(dest => dest.RoleEnum, src => src.MapFrom(s => s.Role))
                .ReverseMap();
        }
    }
}
