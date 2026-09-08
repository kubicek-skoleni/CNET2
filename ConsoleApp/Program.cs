using ConsoleApp.Model;

// LINQ - Language Integrated Query

int[] cisla = [2, 5, 8, 13, 21, -7, 
    100, 0, 15, -3333, 10, 5];

Console.WriteLine(string.Join(", ", cisla));


// FILTR - WHERE
var vetsi20 = cisla.Where(cislo => cislo > 20);

//ORDERBY
var serazene = cisla.OrderByDescending(cislo => cislo);


var vetsi_serazene = cisla.Where(cislo => cislo > 10)
                          .OrderByDescending(cislo => cislo);
                          

Console.WriteLine(string.Join(", ", vetsi_serazene));

var sum = vetsi_serazene.Sum();
Console.WriteLine($"Sum: {sum}");

//AGGREGATE FUNCTIONS
//var sum = cisla.Sum();
//var avg = cisla.Average();
//var min = cisla.Min();
//var max = cisla.Max();
//var count = cisla.Count();

var skip5 = cisla.Skip(5);
var take5 = cisla.Take(5);

//SELECT - PROJECTION - TRANFSORMACE
var result = cisla.Select(cislo => cislo * 2);
Console.WriteLine(string.Join(", ", result));


var any = !cisla.Any(x => x < 0);
var all = cisla.All(x => x > 0);