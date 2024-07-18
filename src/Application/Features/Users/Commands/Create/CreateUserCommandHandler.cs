using Application.Services.UserService;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreatedUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public CreateUserCommandHandler(IMapper mapper, IUserService userService)
    {
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<CreatedUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = _mapper.Map<User>(request); // Mapping profilleri oluştur.
        user.Id = Guid.NewGuid(); // Generate new GUID for user
        user.CreatedDate = DateTime.Now; // Set created date

        User createdUser =  await _userService.AddAsync(user);

        CreatedUserResponse response = _mapper.Map<CreatedUserResponse>(createdUser);

        return response;
    }
}