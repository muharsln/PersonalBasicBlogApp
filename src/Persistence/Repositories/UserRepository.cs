using Application.Repositories;
using Core.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class UserRepository : EfRepositoryBase<User, Guid, ApplicationDbContext>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context) { }
}