using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp;

public class Student
{
    public string Jmeno;

    public string Prijmeni;

    private int RokNarozeni;

    public void SetRokNarozeni(int roknarozeni)
    {
        if (roknarozeni < 1900 || roknarozeni > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(roknarozeni), "Rok narození musí být mezi 1900 a aktuálním rokem.");
        }
        RokNarozeni = roknarozeni;
    }

    public int GetRokNarozeni()
    {
        return RokNarozeni;
    }

    public string CeleJmeno()
    {
        return $"{Jmeno} {Prijmeni}";
    }
}


