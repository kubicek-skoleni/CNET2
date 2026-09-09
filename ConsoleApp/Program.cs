// třidy pro

// Adresu - Ulice, Mesto, PSC, Stat
// Bankovni ucet - Cislo uctu, Majitel, Zustatek
//              - operace - Vklad, Vyber
// Kostka - pocet stran + hod kostkou


using ConsoleApp.Model;

var kostka20 = new Kostka(20);

for(int i = 0; i < 20; i++)
{
    Console.WriteLine($"Hod kostkou: {kostka20.Hod()}");
}

Console.WriteLine("*********");

var kostka6 = new Kostka(6);

List<int> hody = new List<int>();

for (int i = 0; i < 20; i++)
{
    var hod = kostka6.Hod();
    hody.Add(hod);
    Console.WriteLine($"Hod kostkou: {hod}");
}

var prumer = hody.Average();
var pocet_hodu = hody.Count();