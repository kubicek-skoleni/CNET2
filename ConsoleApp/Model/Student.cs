using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp.Model
{
    public class Student : Osoba
    {
        // Jmeno, Prijmeni, RokNarozeni, Trida, Adresa

        #region Property
        public string Trida { get; set; } = string.Empty;
        public IAdresa Adresa { get; set; }
        #endregion

        #region metody
        override public string ToString()
        {
            return $"{Prijmeni} ({Vek()}), {Trida}, {Adresa.FullAddress()}";
        }
        #endregion
    }
}
