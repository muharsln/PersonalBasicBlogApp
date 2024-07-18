using MediatR;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommand : IRequest<CreatedUserResponse>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}