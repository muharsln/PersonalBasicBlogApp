using Core.Entities;
using MediatR;

namespace Application.Features.Posts.Commands.Create;

public class CreatePostCommand : IRequest<CreatedPostResponse>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public ICollection<Guid> CategoryIds { get; set; } = new List<Guid>();
}

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, CreatedPostResponse>
{

    public async Task<CreatedPostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        var post = new Post
        {
            Id = Guid.NewGuid(),
            UserId = request.UserId,
            Title = request.Title,
            Content = request.Content,
            CreatedDate = DateTime.UtcNow
        };

        //if (request.CategoryIds != null && request.CategoryIds.Any())
        //{
        //    post.PostCategories = request.CategoryIds.Select(categoryId => new PostCategory
        //    {
        //        CategoriesId = categoryId,
        //        PostsId = post.Id
        //    }).ToList();
        //}

        return new CreatedPostResponse();

    }
}