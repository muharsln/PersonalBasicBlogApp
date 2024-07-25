using FluentValidation;

namespace Application.Features.Posts.Commands.Create;

public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        RuleFor(p => p.Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(100).WithMessage("Title must not exceed 100 characters");
        RuleFor(p => p.Content)
            .NotEmpty().WithMessage("Content is required");
        RuleFor(p => p.UserId)
            .NotEmpty().WithMessage("UserId is required");
    }
}