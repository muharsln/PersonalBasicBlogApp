namespace Application.Features.Posts.Queries.GetList;

public class GetListPostDto
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}