using Application.Repositories;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Posts.Commands.Create;

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CreatedPostResponse>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<CreatedPostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        Post post = _mapper.Map<Post>(request);
        post.Id = Guid.NewGuid();
        post.CreatedDate = DateTime.UtcNow;

        // Olmayan bir kategori eklenmek isterse patlıyoruz.
        if (request.CategoryIds != null && request.CategoryIds.Any())
        {
            post.PostCategories = request.CategoryIds.Select(categoryId => new PostCategory
            {
                CategoryId = categoryId,
                PostId = post.Id
            }).ToList();
        }

        Post addedPost = await _postRepository.AddAsync(post);
        CreatedPostResponse response = _mapper.Map<CreatedPostResponse>(addedPost);

        return response;
    }
}