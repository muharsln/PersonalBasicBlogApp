using Application.Features.Posts.Commands.Create;
using Application.Features.Posts.Commands.Delete;
using Application.Features.Posts.Commands.Update;
using Application.Features.Posts.Queries.GetList;
using MediatR;

namespace API.Endpoints;

public static class PostEndpoints
{
    public static void MapPostEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/posts", async (IMediator mediator) =>
        {
            IEnumerable<GetListPostDto> response = await mediator.Send(new GetListPostQuery());
            return response;
        });

        endpoints.MapPost("/api/posts", async (CreatePostCommand command, IMediator mediator) =>
        {
            CreatedPostResponse response = await mediator.Send(command);
            return response;
        });


        endpoints.MapDelete("/api/posts/{id}", async (Guid id, IMediator mediator) =>
        {
            var command = new DeletePostCommand { Id = id };
            DeletedPostResponse response = await mediator.Send(command);
            return response;
        });

        endpoints.MapPut("/api/posts", async (UpdatePostCommand command, IMediator mediator) =>
        {
            UpdatedPostResponse response = await mediator.Send(command);
            return response;
        });
    }
}