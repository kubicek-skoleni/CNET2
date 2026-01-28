using Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PeopleDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/", () => "API bìží!");

app.MapGet("/persons/count", (PeopleDbContext db) =>
{
    var count = db.Persons.Count();
    return count;
});

app.MapGet("/person/{id:int}", (PeopleDbContext db, int id) =>
{
    var person = db.Persons
                    .Include(x => x.Address)
                    .Include(x => x.Contracts)
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

    person.DateOfBirth = new DateTime(2007, 11, 30);
    db.SaveChanges();

    if (person == null)
        return Results.NotFound();
    else
        return Results.Ok(person);

});

// hledání osob podle emailu (èást emailu, - obsahuje)
app.MapGet("/person/email/{email}", (PeopleDbContext db, string email) 
    => db.Persons
        .Where(x => x.Email.ToLower()
        .Contains(email.ToLower()))
        .Take(100)
);

app.Run();


