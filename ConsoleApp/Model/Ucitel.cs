using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class Ucitel : Osoba
    {
        public int Plat { get; set; }

        override public string ToString()
        {
            return $"{Prijmeni} ({Vek()}), Plat: {Plat} Kč";
        }
    }
}
