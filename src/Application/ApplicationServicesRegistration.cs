using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using MediatR;
using Application.Services.UserService;
using Application.Services.PostService;

namespace Application;

public static class ApplicationServicesRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IPostService, PostManager>();
    }
}