using Core.Common;

namespace Core.Entities;
public class Comment:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
    public string Text { get; set; }

    public Post Post { get; set; }
    public User User { get; set; }
}