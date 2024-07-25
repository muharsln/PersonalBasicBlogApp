using MediatR;

namespace Application.Features.Posts.Commands.Delete;

public class DeletePostCommand : IRequest<DeletedPostResponse>
{
    public Guid Id { get; set; }

    public ICollection<Guid> CategoryIds { get; set; } = new List<Guid>();
}