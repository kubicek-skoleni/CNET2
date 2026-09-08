
var fruits = new[] { "aPPLE", "BlUeBeRrY", 
    "cHeRry", "RaspbeRry" };


// vypište všechno jako lowercase

var lowercaseFruits = fruits
                .Select(ovoce => ovoce.ToLower());
Console.WriteLine($"Lowercase fruits: {string.Join(", ", lowercaseFruits)}");

// vypište velkými písmeny,
// seřazeno od nejdelšího po nejkratší

var result = fruits.Select(f => f.ToUpper())
    .OrderByDescending(f => f.Length);

Console.WriteLine($"Uppercase fruits ordered by length: {string.Join(", ", result)}");


// kapitalizace prního písmene
string CapitalizeFirstLetter(string input)
{
    if (string.IsNullOrEmpty(input))
        return input;

    return char.ToUpper(input[0]) + input.Substring(1).ToLower();
}