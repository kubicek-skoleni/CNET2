using Model;
using System.Text.Json;

var file = @"C:\Users\Student\Downloads\data2024.json";

var content = File.ReadAllText(file);

var people = JsonSerializer.Deserialize<List<Person>>(content);

var cnt = people.Count();

Console.WriteLine($"načetl jsem {cnt} osob");
    
