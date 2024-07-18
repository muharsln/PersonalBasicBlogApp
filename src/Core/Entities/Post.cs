using Core.Common;

namespace Core.Entities;
public class Post:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public User User { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<PostCategory>? PostCategories { get; set; }
}