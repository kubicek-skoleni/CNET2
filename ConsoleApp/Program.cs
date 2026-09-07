
var prec = 10 + 2;

FromCelsiusToFahrenheit(celsius: 10.5, precision: prec);

double FromCelsiusToFahrenheit(double celsius, int precision = 2)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    fahrenheit = Math.Round(fahrenheit, precision);
    return fahrenheit;
}

void PrintHello(string name)
{
    Console.WriteLine($"Hello, {name}!");
}