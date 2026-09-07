
double FromCelsiusToFahrenheit(double celsius, int precision)
{
    double fahrenheit = (celsius * 9 / 5) + 32;
    fahrenheit = Math.Round(fahrenheit, precision);

    return fahrenheit;
}