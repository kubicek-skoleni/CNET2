﻿using PersonData;
using PersonModel;
using System.Net.Http.Json;

var url = "https://localhost:7031";

var client = new HttpClient();

//Person p = new()
//{
//    FirstName = "Jáchym3",
//    LastName = "Simpson3",
//    DateOfBirth = new DateTime(2003, 5, 3),
//    Email = "jachym3@random.net"
//};

//var result = await client.PostAsJsonAsync<Person>($"{url}/person/create", p);
//var person_created = await result.Content.ReadFromJsonAsync<Person>();


int id = 228;
Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");
Console.WriteLine(p);

p.Email = "novy.email@seznam.cz";

var result = await client.PutAsJsonAsync<Person>($"{url}/person/edit", p);

p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");
Console.WriteLine(p);

Console.ReadLine();





