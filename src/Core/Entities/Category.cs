using Core.Common;

namespace Core.Entities;

public class Category:BaseEntity<Guid>
{
    public string Name { get; set; }

    public ICollection<PostCategory> PostCategories { get; set; }
}