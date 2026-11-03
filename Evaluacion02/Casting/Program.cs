using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un numero con decimales (ejemplo: 12.75): ");
        double numeroDecimal = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        // El casting explicito elimina la parte decimal, sin redondear.
        int parteEntera = (int)numeroDecimal;

        // La conversion de int a double es implicita: no requiere (double).
        double numeroConvertido = parteEntera;

        Console.WriteLine();
        Console.WriteLine("CONVERSIONES DE TIPOS");
        Console.WriteLine($"Numero original: {numeroDecimal}");
        Console.WriteLine($"Parte entera con casting explicito: {parteEntera}");
        Console.WriteLine($"Valor convertido implicitamente: {numeroConvertido}");
        Console.WriteLine($"Tipo de parteEntera: {parteEntera.GetType().Name}");
        Console.WriteLine($"Tipo de numeroConvertido: {numeroConvertido.GetType().Name}");
    }
}