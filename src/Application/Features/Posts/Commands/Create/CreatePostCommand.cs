﻿using MediatR;

namespace Application.Features.Posts.Commands.Create;

public class CreatePostCommand : IRequest<CreatedPostResponse>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public ICollection<Guid> CategoryIds { get; set; } = new List<Guid>();
}