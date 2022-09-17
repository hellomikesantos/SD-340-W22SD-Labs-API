var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/route:number", () =>
{
    return;
});

app.MapGet("/stop:number", () =>
{
    return;
});

app.MapGet("/stopschedule:number", () =>
{
    return;
});

app.Run();