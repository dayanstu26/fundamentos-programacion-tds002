using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const double KG_POR_LIBRA = 0.453592;

        Console.Write("Ingresa el peso en libras: ");
        double pesoLibras = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        Console.Write("Ingresa la temperatura en grados Fahrenheit: ");
        double temperaturaFahrenheit = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        double pesoKilogramos = pesoLibras * KG_POR_LIBRA;
        double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5.0 / 9.0;

        Console.WriteLine();
        Console.WriteLine("RESULTADOS DE LA CONVERSION");
        Console.WriteLine($"{pesoLibras:F2} lb equivalen a {pesoKilogramos:F2} kg.");
        Console.WriteLine($"{temperaturaFahrenheit:F2} °F equivalen a {temperaturaCelsius:F2} °C.");
    }
}