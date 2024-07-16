using FluentValidation;

namespace Application.Features.Users.Command.Create;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(u => u.Username)
            .NotEmpty().WithMessage("Username is required")
            .MaximumLength(25).WithMessage("Username must not exceed 25 characters");

        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("A valid email is required")
            .MaximumLength(50).WithMessage("Email must not exceed 50 characters");

        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
            .MaximumLength(100).WithMessage("Password must not exceed 100 characters");
    }
}