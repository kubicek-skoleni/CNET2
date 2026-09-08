
using ConsoleApp;

var fruits = new[] { "aPPLE", "BlUeBeRrY", 
    "cHeRry", "RaspbeRry", "čučoriedka" };


// vypište všechno jako lowercase

//var lowercaseFruits = fruits
//                .Select(ovoce => ovoce.ToLower());
//Console.WriteLine($"Lowercase fruits: {string.Join(", ", lowercaseFruits)}");

// vypište velkými písmeny,
// seřazeno od nejdelšího po nejkratší

//var result = fruits.Select(f => f.ToUpper())
//    .OrderByDescending(f => f.Length);

//Console.WriteLine($"Uppercase fruits ordered by length: {string.Join(", ", result)}");


// **********



//  vypište s prvními velkými písmeny
var capFruits = fruits
    .Select(slovo =>
    TextTransform.CapitalizeFirstLetter(slovo));

Console.WriteLine($"Capitalized fruits: {string.Join(", ", capFruits)}");


