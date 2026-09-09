using Corp.Database;
using Corp.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PeopleContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

// API endpoints (URL)

app.MapGet("/", () => "API běží");

app.MapGet("/person/{id:int}", (int id, PeopleContext db) =>
{
    var person = db.Persons
                .Include(x => x.Address)
                .Include(x => x.Contracts)
                .Where(person => person.Id == id)
                .FirstOrDefault();

    if(person == null)
    {
        return Results.NotFound($"Nenašel jsem osobu dle id: {id}");
    }

    return Results.Ok(person);
});

    


app.Run();

