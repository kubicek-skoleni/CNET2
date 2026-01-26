var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var strings = new[] { "zero", "one", "two", "three", "four", "five"
    , "six", "seven", "eight", "nine" };
// vypište čísla v poli numbers jako slova

var jako_slova = numbers.Select(num => strings[num]);
Console.WriteLine($"jako slova: {string.Join(", ", jako_slova)}");