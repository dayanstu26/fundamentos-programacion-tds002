using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Referencia de venta BCRD del 02/11/2026:
        // 60.7461 pesos dominicanos por dolar estadounidense.
        const double TASA_USD = 60.7461;

        // Leemos el monto usando punto como separador decimal.
        Console.Write("Ingresa el monto en pesos dominicanos: ");
        double montoPesos = Convert.ToDouble(
            Console.ReadLine(),
            CultureInfo.InvariantCulture
        );

        // Dividimos los pesos entre la tasa para obtener dolares.
        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine();
        Console.WriteLine("CONVERSOR DE MONEDA");
        Console.WriteLine($"Monto en pesos: RD${montoPesos:F2}");
        Console.WriteLine($"Tasa utilizada: RD${TASA_USD:F4} por US$1");
        Console.WriteLine($"Equivalente en dolares: US${montoDolares:F2}");
    }
}