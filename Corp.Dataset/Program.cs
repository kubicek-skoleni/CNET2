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