using Corp.Database;
using Corp.Model;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string filePath = @"C:\Users\Student\source\repos\kubicek3\CNET2\data2024.json";
var content = File.ReadAllText(filePath);

var people 
    = JsonSerializer.Deserialize<List<Person>>(content);

Console.WriteLine($"Počet osob: {people.Count}");

var db = new PeopleContext();

if (db.Persons.Count() == 0)
{
    db.Persons.AddRange(people);
    db.SaveChanges();
    Console.WriteLine("Osoby byly úspěšně přidány do databáze.");
}
else
{
    Console.WriteLine("Osoby již v databázi jsou.");
}




