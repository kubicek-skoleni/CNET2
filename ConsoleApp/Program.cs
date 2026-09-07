using ConsoleApp;

int age = 25;
double salary = 75000.5;
string name = "John Doe";
bool isEmployed = true;
char grade = 'A';
decimal price = 19.99m;

var company = "Tech Corp";
var yearsOfExperience = 5;
var hourlyRate = 345.50m;

int a = 10;
byte b = 20;

a = b;
b = (byte)a;
b = (byte)hourlyRate;

Console.WriteLine($"Company: {company}");
Console.WriteLine($"hourlyRate: {hourlyRate}");
