using Application.Features.Users.Command.Create;
using AutoMapper;
using Core.Entities;

namespace Application.Features.Users.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, CreatedUserResponse>().ReverseMap();
    }
}