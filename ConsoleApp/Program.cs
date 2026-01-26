using ConsoleApp.Model;

var student = new Student()
{
    Prijmeni = "  novak  ",
    RokNarozeni = new DateOnly(2005, 5, 3),
    Trida = "9.A",
    Adresa = new TextovaAdresa
    {
        Ulice = "Hlavni 123",
        Mesto = "Praha",
        PSC = "11000"
    }
};

var student2 = new Student()
{
    Prijmeni = "Buchta",
    RokNarozeni = new DateOnly(2007, 3, 3),
    Trida = "7.A",
    Adresa = new RuianAdresa
    {
        KodObce = 550000,
        NazevObce = "Brno",
        KodUlice = 1234,
        NazevUlice = "Masarykova",
        CisloDomovni = 45,
        Psc = 60200
    }
};

Console.WriteLine("student - textová adresa:");
Console.WriteLine(student);

Console.WriteLine("student - ruian adresa:");
Console.WriteLine(student2);