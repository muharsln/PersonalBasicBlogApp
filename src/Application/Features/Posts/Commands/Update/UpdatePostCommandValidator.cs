using FluentValidation;

namespace Application.Features.Posts.Commands.Update;

public class UpdatePostCommandValidator : AbstractValidator<UpdatePostCommand>
{
    public UpdatePostCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}