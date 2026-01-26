using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class RuianAdresa : IAdresa
    {
        public int KodObce { get; set; }
        public string NazevObce { get; set; }
        public int? KodUlice { get; set; }
        public string NazevUlice { get; set; }
        public int CisloDomovni { get; set; }
        public int Psc { get; set; }

        public string FullAddress()
            => $"{NazevUlice}, {Psc} {NazevObce}";

        public bool IsValid()
        {
            return KodObce > 500000 && KodObce < 600000
            && CisloDomovni > 0
            && Psc >= 10000 && Psc <= 99999;
        }
    }
}
