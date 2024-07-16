using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Command.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreatedUserResponse>
{
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<CreatedUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User user = _mapper.Map<User>(request); // Mapping profilleri oluştur.
        user.Id = Guid.NewGuid(); // Generate new GUID for user
        user.CreatedDate = DateTime.Now; // Set created date

        // Save user to database



        CreatedUserResponse response = _mapper.Map<CreatedUserResponse>(user);

        return Task.FromResult(response);
    }
}