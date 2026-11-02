using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // El año permanece fijo durante la ejecución.
        const int ANIO_ACTUAL = 2026;

        // Pedimos y guardamos el nombre como texto.
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        // Pedimos la edad y convertimos el texto en un entero.
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        // Pedimos la estatura y la convertimos en un número decimal.
        Console.Write("Ingresa tu estatura en metros (ejemplo: 1.75): ");
        double estatura = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        // Calculamos el año de nacimiento aproximado.
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Mostramos los resultados.
        Console.WriteLine();
        Console.WriteLine($"Hola, {nombre}.");
        Console.WriteLine($"Tienes {edad} años.");
        Console.WriteLine($"Tu estatura es de {estatura} metros.");
        Console.WriteLine($"Tu año de nacimiento aproximado es {anioNacimiento}.");
    }
}