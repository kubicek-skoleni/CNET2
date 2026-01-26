using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class WordUpperLower
    {
        public WordUpperLower(string word)
        {
            UpperCase = word.ToUpper();
            LowerCase = word.ToLower();
        }
        public string UpperCase { get; set; }
        public string LowerCase { get; set; }
    }
}
