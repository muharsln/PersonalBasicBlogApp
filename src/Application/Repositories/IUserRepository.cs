using Application.Interfaces;
using Core.Entities;

namespace Application.Repositories;

public interface IUserRepository : IAsyncRepository<User, Guid>{}