using Core.Entities;
using System.Linq.Expressions;

namespace Application.Services.UserService;

public interface IUserService
{
    Task<User> GetAsync(
    Expression<Func<User, bool>> predicate);

    Task<ICollection<User>> GetListAsync(
        Expression<Func<User, bool>>? predicate = null,
        CancellationToken cancellationToken = default);

    Task<User> AddAsync(User user);
    Task<User> UpdateAsync(User user);
    Task<User> DeleteAsync(User user);
}