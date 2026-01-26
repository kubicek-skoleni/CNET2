using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class RuianAdresa
    {
        public int KodObce { get; set; }
        public string NazevObce { get; set; }
        public int? KodUlice { get; set; }
        public string NazevUlice { get; set; }
        public int CisloDomovni { get; set; }
        public int Psc { get; set; }
    }
}
