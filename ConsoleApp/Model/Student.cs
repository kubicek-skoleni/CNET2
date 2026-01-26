using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public class Student
    {
        // Jmeno, Prijmeni, RokNarozeni, Trida, Adresa
        public Student()
        {
        }

        public Student(string prijmeni)
        {
                Prijmeni = prijmeni;
        }

        public Student(string prijmeni, int rokNarozeni) :this(prijmeni)
        {
                RokNarozeni = rokNarozeni;
        }

        #region Property
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
        #endregion
        
        #region metody
        override public string ToString()
        {
            return $"{Prijmeni} ({RokNarozeni}), {Trida}, {Adresa}";
        }
        #endregion
    }
}
