using MediatR;

namespace Application.Features.Posts.Commands.Update;

public class UpdatePostCommand : IRequest<UpdatedPostResponse>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public ICollection<Guid> CategoryIds { get; set; } = new List<Guid>();
}