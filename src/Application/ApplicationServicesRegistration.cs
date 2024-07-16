using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using Application.Features.Users.Command.Create;

namespace Application;

public static class ApplicationServicesRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
    }
}