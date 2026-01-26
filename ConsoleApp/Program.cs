using System.Runtime.CompilerServices;

int[] cisla = [-10, 0, 15, 20, -25, 30, 35 ];
Console.WriteLine(string.Join(", ", cisla));

List<string> slova = ["ahoj", "Pepa", "Alice", "poledne"];

// LINQ

// WHERE
//var result = cisla.Where(cislo => cislo > 100);


// ORDERBY
//var result = cisla.OrderByDescending(cislo => cislo);

// AGREGACNI
//var res = cisla.Min();
//Console.WriteLine($"min: {res}");

// skip/take 
//var result =  cisla.SkipWhile(cislo => cislo < 0);

// First, FirstOrDefault, Single, SingleOrDefault

//var cislo = cisla.Where(x => x > 100).FirstOrDefault();
//Console.WriteLine($"privní > 10: {cislo}");

// SELECT - TRANSFORMACE
var result = cisla.Select(cislo => Math.Abs(cislo));

//All, Any
bool res = cisla.Any(x =>  x > 0);

// vypis
Console.WriteLine(string.Join(", ", result));


