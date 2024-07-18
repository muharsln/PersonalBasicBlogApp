using Core.Common;

namespace Core.Entities
{
    public class PostCategory : BaseEntity<int>
    {
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}