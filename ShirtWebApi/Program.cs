var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing

// "/shirts"

app.MapGet("/shirts", () =>
{
    return "showing all shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"showing the shirt with id: {id}";
});

app.MapPost("/shirts", () =>
{
    return "adding a new shirt";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"updating the shirt with id: {id}";
});

app.MapDelete("/shirts/{id}", (int id) =>
{
    return $"deleting the shirt with id: {id}";
});

app.Run();
