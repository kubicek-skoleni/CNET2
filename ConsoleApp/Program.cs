
using Model;
using System.Net.Http.Json;

var client = new HttpClient();

var url = "https://localhost:7156";
client.BaseAddress = new Uri(url);

Person person = null;
try
{
	person = await client.GetFromJsonAsync<Person>("/person/6000");
}
catch (Exception ex)
{

    Console.WriteLine($"nastala chyba: {ex.Message}");
}

var result = await client.GetAsync("/person/11");

if(result.IsSuccessStatusCode)
{
    person = await result.Content.ReadFromJsonAsync<Person>();
}
else
{
    Console.WriteLine($"Chyba při získávání osoby: {result.StatusCode}");
}


Console.WriteLine($"Jméno: {person?.FirstName} {person?.LastName}");

Console.WriteLine("Konec");
Console.ReadLine();