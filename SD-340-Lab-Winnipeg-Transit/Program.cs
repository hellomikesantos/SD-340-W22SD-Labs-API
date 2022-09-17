var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello world.";
});

app.MapGet("/happy", () =>
{
    return "It is happy";
});

app.Run();