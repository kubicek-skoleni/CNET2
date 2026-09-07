
// 1. udělejte metodu která vrátí větši ze dvou celých čísel

// Greater, Vetsi, Vetsi, VetsiCislo
// Max

int Vetsi(int a, int b, int c) 
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