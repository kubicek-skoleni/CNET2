using Corp.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// API endpoints (URL)

app.MapGet("/", () => "API běží");

app.MapGet("/person/{id:int}", (int id) =>
{
    var person = new Person
    {
        Id = id,
        FirstName = "Nepojmenovaný",
        LastName = "Nepříjmenovaný"
    };

    return person;
});

    


app.Run();

