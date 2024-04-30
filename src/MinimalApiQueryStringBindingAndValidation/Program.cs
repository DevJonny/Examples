using FluentValidation;
using MinimalApiQueryStringBindingAndValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddValidatorsFromAssemblyContaining<Ping>();

var app = builder.Build();

app.UseHttpsRedirection();

app
    .MapGet("/ping", ([AsParameters] Ping orderBy) => Results.Ok(orderBy.Message))
    .AddEndpointFilter<PingValidatorFilter<Ping>>();

app.Run();

public record Ping(string Message);