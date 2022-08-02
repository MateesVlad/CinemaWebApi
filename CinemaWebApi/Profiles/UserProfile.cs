﻿using AutoMapper;

namespace CinemaWebApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.Users, ExternalModels.UsersDTO>();
            CreateMap<ExternalModels.UsersDTO, Entities.Users>();
        }
    }
}
