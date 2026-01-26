using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class Student
    {
        // Jmeno, Prijmeni, RokNarozeni, Trida, Adresa

        private string prijmeni;

        public string Prijmeni {
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
        public int RokNarozeni { get; set; }
        public string Trida { get; set; }
        public string Adresa { get; set; }
    }
}
