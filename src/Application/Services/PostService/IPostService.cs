using Core.Entities;
using System.Linq.Expressions;

namespace Application.Services.PostService;

public interface IPostService
{
    Task<Post> GetAsync(
    Expression<Func<Post, bool>> predicate);

    Task<ICollection<Post>> GetListAsync(
        Expression<Func<Post, bool>>? predicate = null,
        CancellationToken cancellationToken = default);

    Task<Post> AddAsync(Post post);
    Task<Post> UpdateAsync(Post post);
    Task<Post> DeleteAsync(Post post);
}