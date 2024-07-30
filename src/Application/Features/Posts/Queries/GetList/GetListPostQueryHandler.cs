using Application.Repositories;
using Application.Services.PostService;
using AutoMapper;
using MediatR;

namespace Application.Features.Posts.Queries.GetList;

public class GetListPostQueryHandler : IRequestHandler<GetListPostQuery, IEnumerable<GetListPostDto>>
{
    private readonly IPostService _postService;
    private readonly IMapper _mapper;

    public GetListPostQueryHandler(IPostService postService, IMapper mapper)
    {
        _postService = postService;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetListPostDto>> Handle(GetListPostQuery request, CancellationToken cancellationToken)
    {
        var posts = await _postService.GetListAsync();

        var response = _mapper.Map<IEnumerable<GetListPostDto>>(posts);

        return response;
    }
}