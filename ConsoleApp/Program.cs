// třidy pro

// Adresu - Ulice, Mesto, PSC, Stat
// Bankovni ucet - Cislo uctu, Majitel, Zustatek
//              - operace - Vklad, Vyber
// Kostka - pocet stran + hod kostkou


using ConsoleApp.Model;

var kostka = new Kostka(20);

for(int i = 0; i < 20; i++)
{
    Console.WriteLine($"Hod kostkou: {kostka.Hod()}");
}