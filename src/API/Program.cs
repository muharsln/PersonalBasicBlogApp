using Persistence;
using Application;
using Application.Features.Users.Commands.Create;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

var app = builder.Build();

app.MapPost("/api/users", async (CreateUserCommand command, IMediator mediator) =>
{
    CreatedUserResponse response = await mediator.Send(command);

    return Results.Created($"/api/users/{response.Id}", response);
});

//app.MapPost("/api/users", () =>
//{
//    return "test";
//});

app.UseHttpsRedirection();

app.Run();