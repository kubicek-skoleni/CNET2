int[] numbers = [10, 20, 30, 40, 50];

try
{
    numbers[5] = 100;
    Console.WriteLine(numbers[5]);
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine($"Chyba: Index mimo rozsah");
}
catch(Exception ex)
{
    Console.WriteLine($"Chyba: {ex.Message}");
}

Console.WriteLine("pokračuji");