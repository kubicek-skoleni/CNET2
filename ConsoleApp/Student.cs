using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp;

public class Student
{
    const string jmeno = "Nepojmenovaný";
    
    private int _rokNarozeni;

    public required string  Jmeno { get; set; } = string.Empty;

    public string Prijmeni { get; set; } = "Nepojmenovaný";

    public int RokNarozeni
    {
        get
        {
            return _rokNarozeni;
        }
        set
        {
            if (value < 1900 || value > DateTime.Now.Year)
               throw new ArgumentOutOfRangeException("Rok narozeni musi byt mezi 1900 a aktualnim rokem.");
            
            _rokNarozeni = value;
        }
    }


    public string CeleJmeno()
    {
        //jmeno = string.IsNullOrEmpty(Jmeno) ? "Nepojmenovaný" : Jmeno;
        return $"{Jmeno} {Prijmeni}";
    }
}


