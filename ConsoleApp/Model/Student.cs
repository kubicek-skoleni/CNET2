using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp.Model
{
    public class Student
    {
        // Jmeno, Prijmeni, RokNarozeni, Trida, Adresa

        private string prijmeni;

        #region Property
        public required string Prijmeni {
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
        public string Trida { get; set; } = string.Empty;
        public IAdresa Adresa { get; set; }
        #endregion

        #region metody
        override public string ToString()
        {
            return $"{Prijmeni} ({RokNarozeni}), {Trida}, {Adresa.FullAddress()}";
        }

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
        #endregion
    }
}
