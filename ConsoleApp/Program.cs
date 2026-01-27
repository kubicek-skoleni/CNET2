using Data;
using Model;

var dbContext = new PeopleDbContext();



// 1. nejstarší osoba
var oldest = dbContext.Persons
    .OrderBy(p => p.DateOfBirth)
    .FirstOrDefault();
Console.WriteLine($"Nejstarší osoba: {oldest?.FirstName} {oldest?.LastName}, narozen/a: {oldest?.DateOfBirth.ToShortDateString()}");


// 2. kolik různých měst je v databázi
var unique_cities = dbContext.Addresses
    .Select(a => a.City)
    .Distinct()
    .Count();
Console.WriteLine($"Unikátních měst: {unique_cities}");


// 3. kolik lidi je z Brna
var people_from_brno = dbContext.Persons
    .Where(p => p.Address != null && p.Address.City == "Brno")
    .Count();
Console.WriteLine($"Počet lidí z Brna: {people_from_brno}");

// 4. kolik osob bez smluv (pokud nějaké)
var people_without_contracts = dbContext.Persons
    .Where(p => p.Contracts == null || !p.Contracts.Any())
    .Count();
Console.WriteLine($"Počet osob bez smluv: {people_without_contracts}");

// 5. kolik osob bez adresy
var people_without_address = dbContext.Persons
    .Where(p => p.Address == null)
    .Count();
Console.WriteLine($"Počet osob bez adresy: {people_without_address}");

// 10 měst s nejvíc lidmi

var top10_cities = dbContext.Persons
            .Where(osoba => osoba.Address != null)
            .GroupBy(osoba => osoba.Address.City)
            .Select(skupina => new
            {
                City = skupina.Key,
                Count = skupina.Count()
            })
            .OrderByDescending(x => x.Count)
            .Take(10);

Console.WriteLine("Top 10 měst s nejvíc lidmi:");
foreach (var city in top10_cities)
{
    Console.WriteLine($"{city.City}: {city.Count} lidí");
}


