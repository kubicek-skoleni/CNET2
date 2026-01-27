using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class Osoba
    {
        private string prijmeni; 
        public required string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                value = value.Trim();
                var prvni = new string(value.Take(1).ToArray()).ToUpper();
                var zbytek = value.Substring(1).ToLower();
                prijmeni = prvni + zbytek;
            }
        }
        public DateOnly RokNarozeni { get; set; }

        public int Vek()
        {
            var dnes = DateOnly.FromDateTime(DateTime.Now);
            var vek = dnes.Year - RokNarozeni.Year;
            if (dnes < RokNarozeni.AddYears(vek))
            {
                vek--;
            }
            return vek;
        }
    }
}
