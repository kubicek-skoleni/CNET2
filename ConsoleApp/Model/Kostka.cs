using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model;

public class Kostka
{
    public Kostka(int pocetSten)
    {
        if (pocetSten < 1)
            throw new ArgumentException("Počet stěn musí být kladný.", nameof(pocetSten));
        
        this.pocetSten = pocetSten;
    }
    private int pocetSten;

    public int Hod()
        => Random.Shared.Next(1, pocetSten + 1);
    
}
