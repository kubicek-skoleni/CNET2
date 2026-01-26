

using ConsoleApp.Model;

var student = new Student() 
{ 
    Prijmeni = "  novak  ",
    RokNarozeni = new DateOnly(2005,5,3),
    Trida = "9.A"
};

student.Adresa.Ulice = "Hlavni 123";


Console.WriteLine(student);