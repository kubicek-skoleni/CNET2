using Corp.Model;
using System.Text.Json;

Console.WriteLine("Hello, World!");

string filePath = @"C:\Users\Student\source\repos\kubicek3\CNET2\data2024.json";
var content = File.ReadAllText(filePath);

var people 
    = JsonSerializer.Deserialize<List<Person>>(content);

Console.WriteLine($"Počet osob: {people.Count}");


