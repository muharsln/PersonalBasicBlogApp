using Application.Repositories;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Posts.Commands.Update;

public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, UpdatedPostResponse>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<UpdatedPostResponse> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        // postId yerine requst'den userId almak yerine getAsync ile userId alınabilir.
        Post post = await _postRepository.GetAsync(predicate: p => p.Id == request.Id);
        post = _mapper.Map(request, post);

        await _postRepository.UpdateAsync(post);

        UpdatedPostResponse response = _mapper.Map<UpdatedPostResponse>(post);
        return response;
    }
}