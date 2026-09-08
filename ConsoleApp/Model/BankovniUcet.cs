using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model;

public class BankovniUcet
{
    private decimal _zustatek;
    public string CisloUctu { get; set; } = string.Empty;

    public string Majitel { get; set; } = string.Empty;

    public decimal Zustatek { get { return _zustatek; } }

    public decimal Vlozit(decimal castka)
    {
        if (castka <= 0)
            throw new ArgumentException("Částka musí být kladná.", nameof(castka));
        
        _zustatek += castka;
        
        return Zustatek;
    }

    public decimal Vybrat(decimal castka)
    {
        if (castka <= 0)
            throw new ArgumentException("Částka musí být kladná.", nameof(castka));

        if (castka > Zustatek)
            throw new InvalidOperationException("Nedostatečný zůstatek na účtu.");

        _zustatek -= castka;

        return Zustatek;
    }





    public override string ToString()
        => $"Bankovní účet: {CisloUctu}, Majitel: {Majitel}, Zůstatek: {Zustatek:C}";
    

}
