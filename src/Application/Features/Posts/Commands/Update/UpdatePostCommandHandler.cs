
using Application.Services.PostService;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Posts.Commands.Update;

public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, UpdatedPostResponse>
{
    private readonly IPostService _postService;
    private readonly IMapper _mapper;

    public UpdatePostCommandHandler(IPostService postService, IMapper mapper)
    {
        _postService = postService;
        _mapper = mapper;
    }

    public async Task<UpdatedPostResponse> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        // postId yerine requst'den userId almak yerine getAsync ile userId alınabilir.
        Post post = await _postService.GetAsync(predicate: p => p.Id == request.Id);
        post = _mapper.Map(request, post);

        await _postService.UpdateAsync(post);

        UpdatedPostResponse response = _mapper.Map<UpdatedPostResponse>(post);
        return response;
    }
}