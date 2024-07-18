using Application.Repositories;
using Core.Entities;
using System.Linq.Expressions;

namespace Application.Services.PostService;

public class PostManager : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostManager(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<Post> AddAsync(Post post)
    {
        Post addedPost = await _postRepository.AddAsync(post);
        return addedPost;
    }

    public async Task<Post> DeleteAsync(Post post)
    {
        Post deletedPost = await _postRepository.DeleteAsync(post);
        return deletedPost;
    }

    public async Task<Post> GetAsync(Expression<Func<Post, bool>> predicate)
    {
        Post post = await _postRepository.GetAsync(predicate);
        return post;
    }

    public async Task<ICollection<Post>> GetListAsync(Expression<Func<Post, bool>>? predicate = null, CancellationToken cancellationToken = default)
    {
        ICollection<Post> posts = await _postRepository.GetListAsync(predicate, cancellationToken);
        return posts;
    }

    public async Task<Post> UpdateAsync(Post post)
    {
        Post updatedPost = await _postRepository.UpdateAsync(post);
        return updatedPost;
    }
}