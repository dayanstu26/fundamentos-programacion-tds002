using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const double FACTOR_DIAMETRO = 2.0;

        // Leemos todas las medidas usando la misma unidad.
        Console.Write("Ingresa el radio del circulo: ");
        double radio = Convert.ToDouble(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        Console.Write("Ingresa el primer cateto del triangulo: ");
        double catetoA = Convert.ToDouble(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        Console.Write("Ingresa el segundo cateto del triangulo: ");
        double catetoB = Convert.ToDouble(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        // Calculamos las medidas del circulo y la hipotenusa.
        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = FACTOR_DIAMETRO * Math.PI * radio;
        double hipotenusa = Math.Sqrt(
            Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)
        );

        // Mostramos los resultados con dos decimales.
        Console.WriteLine();
        Console.WriteLine("RESULTADOS DE GEOMETRIA");
        Console.WriteLine($"Area del circulo: {area:F2} unidades cuadradas.");
        Console.WriteLine($"Circunferencia: {circunferencia:F2} unidades.");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2} unidades.");
    }
}