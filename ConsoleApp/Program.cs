using ConsoleApp.Model;

Auto auto1 = new Auto()
{
    Spz = "1A2 3456",
    Barva = "Červená",
    PocetDveri = 5,
    Palivo = TypPaliva.BENZIN,
    Spotreba = 6.5,
    VelikostKol = 16,
    VykonKw = 110,
    Vyrobce = "Toyota",
    Model = "Corolla",
    DatumStk = new DateTime(2023, 5, 15)
};

var auto2 = new Auto()
{
    Spz = "2B3 4567",
    Barva = "Modrá",
    PocetDveri = 5,
    Palivo = TypPaliva.NAFTA,
    Spotreba = 5.2,
    VelikostKol = 16,
    VykonKw = 90,
    Vyrobce = "Ford",
    Model = "Focus",
    DatumStk = new DateTime(2023, 6, 15)
};

Auto auto3 = new()
{
    Spz = "EL7 5678",
    Barva = "Zelená",
    PocetDveri = 5,
    Palivo = TypPaliva.ELEKTRICKY,
    Spotreba = 0.0,
    VelikostKol = 18,
    VykonKw = 150,
    Vyrobce = "Tesla",
    Model = "Model 3",
    DatumStk = new DateTime(2023, 7, 15)
};


var auta = new List<Auto>();
auta.Add(auto1);
auta.Add(auto2);
auta.Add(auto3);

foreach (var auto in auta)
{
    Console.WriteLine(auto);
}

var datum = new DateTime(1000, 1, 1);

Console.WriteLine(datum);