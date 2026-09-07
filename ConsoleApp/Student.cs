using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp;

public class Student
{
    public Student()
    {
        Jmeno = "Neznámý";
        Prijmeni = "Neznámý";
        RokNarozeni = 2000;
    }
    public Student(string jmeno, string prijmeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }
    public Student(string jmeno, string prijmeni, int rok) : this(jmeno, prijmeni)
    {
       RokNarozeni = rok;
    }

    private int _rokNarozeni;

    public string Jmeno;

    public string Prijmeni;

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
        return $"{Jmeno} {Prijmeni}";
    }
}


