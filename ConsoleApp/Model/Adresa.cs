using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model;

public class Adresa
{
    public string Ulice {  get; set; }
    public string Mesto { get; set; }
    public string PSC { get; set; }
    public string Stat { get; set; }
    public override string ToString()
        => $"{Ulice}, {Mesto}, {PSC}, {Stat}";
    
}
