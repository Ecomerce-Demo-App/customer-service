var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/customers/{id}", (string id) =>
{
    return new
    {
        Id = id,
        Name = "John Doe",
        Email = "john@test.com"
    };
});

app.Run("http://localhost:5001");
