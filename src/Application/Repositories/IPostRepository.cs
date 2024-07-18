using Application.Interfaces;
using Core.Entities;

namespace Application.Repositories;

public interface IPostRepository : IAsyncRepository<Post, Guid>{}