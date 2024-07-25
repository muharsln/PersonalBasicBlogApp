using Persistence;
using Application;
using API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

var app = builder.Build();

app.MapUserEndpoints();
app.MapPostEndpoints();

app.UseHttpsRedirection();

app.Run();