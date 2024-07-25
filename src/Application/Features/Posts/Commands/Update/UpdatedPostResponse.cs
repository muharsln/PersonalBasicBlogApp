namespace Application.Features.Posts.Commands.Update;

public class UpdatedPostResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}