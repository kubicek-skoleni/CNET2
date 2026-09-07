int[] numbers = [10, 20, 30, 40, 50];

try
{
    numbers[5] = 100;
    Console.WriteLine(numbers[5]);
}
//catch(IndexOutOfRangeException)
//{
//    Console.WriteLine($"Chyba: Index mimo rozsah");
//}
catch(Exception ex)
{
    DateTime currentTime = DateTime.Now;

    var fileName = currentTime.ToString("yyyy-MM-dd_HH-mm-ss") + "_error_log.txt";
    var message = $"{ex.Message}{Environment.NewLine}{ex.StackTrace}";

    File.WriteAllText(fileName, message);
    Console.WriteLine($"Chyba zaznamenana do souboru: {fileName}");
}

Console.WriteLine("pokračuji");