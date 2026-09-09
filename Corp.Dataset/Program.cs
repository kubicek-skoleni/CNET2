using Corp.Model;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string filePath = @"C:\Users\Student\source\repos\kubicek3\CNET2\data2024.json";
var content = File.ReadAllText(filePath);

var people 
    = JsonSerializer.Deserialize<List<Person>>(content);

Console.WriteLine($"Počet osob: {people.Count}");


// najdete nejmladsi a nejstarsi osobu
// vypiste do konzole


var nejmladsi = people
    .OrderByDescending(p => p.DateOfBirth)
    .First();

Console.WriteLine(nejmladsi);


var nejstarsi = people
    .OrderBy(p => p.DateOfBirth)
    .First();

Console.WriteLine(nejstarsi);

string email1 = "Detmar.Matous@gmail.com";
string email2 = "neexistujici@gmail.com";
string email3 = "";

NajdiPodleEmailu(email1);
NajdiPodleEmailu(email2);
NajdiPodleEmailu(email3);

void NajdiPodleEmailu(string email)
{
    if (string.IsNullOrEmpty(email))
    {
        Console.WriteLine("Email není zadán.");
        return;
    }

    var person = people
        .Where(osoba => osoba.Email == email)
        .FirstOrDefault();

    if (person == null)
    {
        Console.WriteLine("Nenašel jsem osobu s emailem: " + email);
        return;
    }

    Console.WriteLine($"Našel jsem osobu: {person}");
}


