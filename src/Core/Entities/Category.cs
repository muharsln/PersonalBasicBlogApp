using Core.Common;

namespace Core.Entities;
public class Category:BaseEntity<Guid>
{
    public string Name { get; set; }

    public ICollection<Post> Posts { get; set; } // Çoktan çoğa ilişki için
}