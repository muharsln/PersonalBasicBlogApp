using Application.Repositories;
using Core.Entities;
using Persistence.Context;

namespace Persistence.Repositories;

public class PostRepository : EfRepositoryBase<Post, Guid, ApplicationDbContext>, IPostRepository
{
    public PostRepository(ApplicationDbContext context) : base(context) { }
}