
Console.WriteLine($"Vetsi(10, 20) = {Vetsi(10, 20)}");
Console.WriteLine($"Fullname(Pavel, Kubát) {FullName("Pavel", "Kubát")}");
Console.WriteLine($"IsValid(password123) {IsValid("password123")}");
Console.WriteLine($"MinutesToSeconds(3) {MinutesToSeconds(3)}");

//tuple - přes tečky
var result = SecondsToMinutes(125);
Console.WriteLine($"SecondsToMinutes(125) = {result.minutes} min, {result.over} sec");

//tuple - přes deconstruction
(int min, int sec) = SecondsToMinutes(190);
Console.WriteLine($"SecondsToMinutes(190) = {min} min, {sec} sec");

// 1. udělejte metodu která vrátí větši ze dvou celých čísel
// Greater, Vetsi, Vetsi, VetsiCislo
// Max

int Vetsi(int a, int b) 
            => (a > b) ? a : b;

// 2. metodu FullName, která spojí
// jméno a příjmení do jednoho řetězce a vrátí ho

string FullName(string firstName, string lastName) 
    => $"{firstName}    {lastName}";


// 3. metodu na kontrolu validity hesla (delší než 8 znaků)
// PassworCheck, IsValid, PlatneHeslo, JePlatneHeslo

bool IsValid(string password) => password.Length > 8;


// 4. metodu na převod minut na sekundy
// PrevedMinNaSek, PocetSekund, MinutesToSeconds

int MinutesToSeconds(int minutes)
{
    return minutes * 60;
}

(int minutes, int over) SecondsToMinutes(int seconds)
{
    int minutes = seconds / 60;
    int over = seconds % 60;
    return (minutes, over);
}

