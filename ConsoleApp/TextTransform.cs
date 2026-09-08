using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp;

public class TextTransform
{
    // kapitalizace prvního písmene
    public static string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var firstLetter = input[0];
        return char.ToUpper(firstLetter)
            + input.Substring(1).ToLower();
    }
}
