using ConsoleApp;
using System;

int[] numbers = { 11, 2, 13, -97542, 44, -5, 6, 127, -99, 0, 256, 0, 12, 11 };

//// 1.  kolik obsahuje pole kladných čísel
//// 2.  kolik obsahuje pole záporných čísel
//// 3.  sumu kladných hodnot
//// 4.  největší absolutní hodnotu
//// 5.  všechna kladná sudá čísla
//// 6.  seřaďte pole od nejmenších po největší hodnoty,
//// 7.  přeskočte první 3 prvky a seřaďte zbytek hodnot
///

var pocet_kladnych = numbers.Count(x => x > 0);
Console.WriteLine($"pocet_kladnych: {pocet_kladnych}");

var pocet_zapornych = numbers.Where(x => x < 0).Count();
Console.WriteLine($"pocet_zapornych: {pocet_zapornych}");

var suma_kladnych = numbers.Where(x => x > 0).Sum();
Console.WriteLine($"suma_kladnych: {suma_kladnych}");

var nejv_abs = numbers.Select(x => Math.Abs(x)).Max();
Console.WriteLine($"nejv_abs: {nejv_abs}");

var kladna_suda = numbers.Where(x => x > 0).Where(x => x % 2 == 0);
Console.WriteLine($"kladna_suda: {string.Join(", ", kladna_suda)}");

var ordered = numbers.OrderBy(x => x);
Console.WriteLine($"ordered: {string.Join(", ", ordered)}");

var skip3sum = numbers.Skip(3).Sum();
Console.WriteLine($"skip3sum: {skip3sum}");


////////////
///

var fruits = new[] { "aPPLE", "BlUeBeRrY", "cHeRry", "RaspbeRry" };

//// zjistěte kolik obsahují všechna slova v poli "fruits" dohromady 
var dohromady_pismen = fruits.Select(x => x.Length).Sum();
Console.WriteLine($"dohromady pismen {dohromady_pismen}");

////
var lowercaseall = fruits.Select(x => x.ToLower());
Console.WriteLine($"lowercaseall: {string.Join(", ", lowercaseall)}");

//// uppercase + lowercase
var upper_lower_class = fruits.Select(x => new WordUpperLower(x));

// tuple - seskupení hodnot
var upper_lower_anon = fruits.Select(x => new 
{
    UpperCase = x.ToUpper(),
    LowerCase = x.ToLower()
});

var upper_lower_tupple = fruits.Select(x => (Lower: x.ToLower(), Upper: x.ToUpper()));

foreach (var item in upper_lower_tupple)
{
    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
}


int.TryParse("123", out int result);

(bool success, int value) ModernParse(string input)
{
    bool result = int.TryParse(input, out int value);
    return (success: result, value: value);
}

var parseresult = ModernParse("333333");

if(parseresult.success)
{
    Console.WriteLine($"Parsed value: {parseresult.value}");
}
else
{
    Console.WriteLine("Parsing failed.");
}