using Application.Features.Users.Commands.Create;
using MediatR;

namespace API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/api/users", async (CreateUserCommand command, IMediator mediator) =>
        {
            CreatedUserResponse response = await mediator.Send(command);
            return response;
        });
    }
}