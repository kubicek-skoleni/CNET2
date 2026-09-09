using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtentions;

public static class ExtensionMethods
{
    /// <summary>
    /// Capitalizes the first letter of the input string and converts the rest to lowercase.
    /// </summary>
    /// <param name="input">libovolný string</param>
    /// <returns>První velké, zbytek malé</returns>
    public static string CapitalizeFirstLetter(this string input, bool convertToLowerCase = true)
    {
        if (string.IsNullOrEmpty(input))
            return input;
        var firstLetter = input[0];
        return char.ToUpper(firstLetter)
            + input.Substring(1).ToLower();
    }
}
