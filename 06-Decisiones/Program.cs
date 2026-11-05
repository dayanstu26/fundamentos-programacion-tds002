using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PARTE 1: CALIFICACION");
        Console.Write("Ingresa una nota entera entre 0 y 100: ");

        // Validamos que la entrada sea un entero dentro del rango.
        bool notaValida = int.TryParse(Console.ReadLine(), out int nota);

        if (!notaValida || nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota invalida. Debes ingresar un entero de 0 a 100.");
        }
        else if (nota >= 90)
        {
            Console.WriteLine("Calificacion: A");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("Calificacion: B");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Calificacion: C");
        }
        else
        {
            Console.WriteLine("Calificacion: F");
        }

        Console.WriteLine();
        Console.WriteLine("PARTE 2: CALCULADORA");

        Console.Write("Ingresa el primer numero (usa punto para decimales): ");
        bool primerNumeroValido = double.TryParse(
            Console.ReadLine(),
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out double numero1
        );

        Console.Write("Ingresa el segundo numero: ");
        bool segundoNumeroValido = double.TryParse(
            Console.ReadLine(),
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out double numero2
        );

        // Si alguna entrada no es numerica, terminamos el programa.
        if (!primerNumeroValido || !segundoNumeroValido)
        {
            Console.WriteLine("Entrada invalida. Debes ingresar numeros.");
            return;
        }

        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.Write("Selecciona una opcion: ");

        if (!int.TryParse(Console.ReadLine(), out int opcion))
        {
            Console.WriteLine("Opcion invalida. Debes escribir un numero del 1 al 4.");
            return;
        }

        // Seleccionamos la operacion segun la opcion introducida.
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Suma: {numero1 + numero2}");
                break;

            case 2:
                Console.WriteLine($"Resta: {numero1 - numero2}");
                break;

            case 3:
                Console.WriteLine($"Producto: {numero1 * numero2}");
                break;

            case 4:
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                }
                else
                {
                    Console.WriteLine($"Division: {numero1 / numero2}");
                }
                break;

            default:
                Console.WriteLine("Opcion invalida. Selecciona del 1 al 4.");
                break;
        }
    }
}