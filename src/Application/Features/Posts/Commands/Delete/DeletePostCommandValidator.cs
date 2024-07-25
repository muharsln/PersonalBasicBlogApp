using FluentValidation;

namespace Application.Features.Posts.Commands.Delete;

public class DeletePostCommandValidator : AbstractValidator<DeletePostCommand>
{
    public DeletePostCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}