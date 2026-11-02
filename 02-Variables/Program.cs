using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        const int ANIO_ACTUAL = 2026;

        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine() ?? "";

       
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Ingresa tu estatura en metros (ejemplo: 1.75): ");
        double estatura = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        
        int anioNacimiento = ANIO_ACTUAL - edad;

        
        Console.WriteLine();
        Console.WriteLine($"Hola, {nombre}.");
        Console.WriteLine($"Tienes {edad} años.");
        Console.WriteLine($"Tu estatura es de {estatura} metros.");
        Console.WriteLine($"Tu año de nacimiento aproximado es {anioNacimiento}.");
    }
}