using Application.Repositories;
using Core.Entities;
using System.Linq.Expressions;

namespace Application.Services.UserService;

public class UserManager : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> AddAsync(User user)
    {
        User addedUser = await _userRepository.AddAsync(user);
        return addedUser;
    }

    public async Task<User> DeleteAsync(User user)
    {
        User deleledUser = await _userRepository.DeleteAsync(user);
        return deleledUser;
    }

    public async Task<User> GetAsync(Expression<Func<User, bool>> predicate)
    {
        User user = await _userRepository.GetAsync(predicate);
        return user;
    }

    public async Task<ICollection<User>> GetListAsync(Expression<Func<User, bool>>? predicate = null, CancellationToken cancellationToken = default)
    {
        ICollection<User> users = await _userRepository.GetListAsync(predicate, cancellationToken);
        return users;
    }

    public async Task<User> UpdateAsync(User user)
    {
        User updatedUser = await _userRepository.UpdateAsync(user);
        return updatedUser;
    }
}