using Application.Features.Posts.Commands.Create;
using Application.Features.Posts.Commands.Delete;
using Application.Features.Posts.Commands.Update;
using Application.Features.Posts.Queries.GetList;
using AutoMapper;
using Core.Entities;

namespace Application.Features.Posts.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Post, CreatePostCommand>().ReverseMap();
        CreateMap<Post, CreatedPostResponse>().ReverseMap();

        CreateMap<Post, DeletedPostResponse>().ReverseMap();
        CreateMap<Post, DeletePostCommand>().ReverseMap();

        CreateMap<Post, UpdatedPostResponse>().ReverseMap();
        CreateMap<Post, UpdatePostCommand>().ReverseMap();

        CreateMap<Post, GetListPostDto>().ReverseMap();
    }
}