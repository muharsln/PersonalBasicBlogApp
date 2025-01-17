﻿using Application.Services.PostService;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Posts.Commands.Delete;

public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, DeletedPostResponse>
{
    private readonly IPostService _postService;
    private readonly IMapper _mapper;

    public DeletePostCommandHandler(IPostService postService, IMapper mapper)
    {
        _postService = postService;
        _mapper = mapper;
    }

    public async Task<DeletedPostResponse> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        Post post = _mapper.Map<Post>(request);
        
        // Eğer herhangi bir kategorisi var ise, silinmesi gereken kategorileri sil.
        // PostId'si bu post'a ait olan tüm PostCategory'leri sil.


        await _postService.DeleteAsync(post);
        DeletedPostResponse response = _mapper.Map<DeletedPostResponse>(post);

        return response;
    }
}