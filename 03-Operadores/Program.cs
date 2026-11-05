using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa el primer numero entero: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo numero entero: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int suma = x + y;
        int resta = x - y;
        int producto = x * y;
        bool esPar = x % 2 == 0;

        Console.WriteLine();
        Console.WriteLine("RESULTADOS");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Producto: {producto}");

        // Comprobamos el divisor antes de calcular divisiones y residuo.
        if (y != 0)
        {
            double divisionReal = (double)x / y;
            int divisionEntera = x / y;
            int residuo = x % y;

            Console.WriteLine($"Division real: {divisionReal}");
            Console.WriteLine($"Division entera: {divisionEntera}");
            Console.WriteLine($"Residuo: {residuo}");
        }
        else
        {
            Console.WriteLine("Division real: no se puede dividir entre cero.");
            Console.WriteLine("Division entera: no se puede dividir entre cero.");
            Console.WriteLine("Residuo: no se puede calcular con divisor cero.");
        }

        Console.Write("El primero es par: ");
        Console.WriteLine(esPar ? "true" : "false");
    }
}

/*
Prueba de escritorio de las operaciones de este programa.
Entradas: x = 10, y = 3.

suma = 10 + 3 = 13
resta = 10 - 3 = 7
producto = 10 * 3 = 30
esPar = (10 % 2 == 0) = true

Como y es diferente de cero:
divisionReal = (double)10 / 3 = 3.3333333333333335 aproximadamente
divisionEntera = 10 / 3 = 3
residuo = 10 % 3 = 1

Salidas:
Suma: 13
Resta: 7
Producto: 30
Division real: aproximadamente 3.3333333333333335
Division entera: 3
Residuo: 1
El primero es par: true
*/