using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Leemos el nombre como texto y convertimos la edad a entero.
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        // Usamos punto como separador decimal para la estatura.
        Console.Write("Ingresa tu estatura en metros (ejemplo: 1.79): ");
        double estatura = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        // Convertimos la respuesta true o false a un valor booleano.
        Console.Write("¿Trabajas? Escribe true o false: ");
        bool trabaja = Convert.ToBoolean(Console.ReadLine());

        // Estimamos el año de los 30 a partir del año actual y la edad.
        int anioActual = DateTime.Now.Year;
        int anioCumple30 = anioActual + (30 - edad);

        Console.WriteLine();
        Console.WriteLine("FICHA PERSONAL");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} metros");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Año estimado en que cumples 30: {anioCumple30}");
    }
}