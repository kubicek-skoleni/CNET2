using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class TextovaAdresa : IAdresa
    {
        public string Ulice { get; set; }
        public string Mesto { get; set; }
        public string PSC { get; set; }

        public string FullAddress()
            => $"{Ulice}, {PSC} {Mesto}";

        public bool IsValid()
        => !string.IsNullOrEmpty(Ulice) && !string.IsNullOrEmpty(PSC);
        
    }
}
