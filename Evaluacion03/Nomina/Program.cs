using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Tasas indicadas en la consigna, expresadas como fracciones.
        const decimal TASA_AFP = 0.0287m;
        const decimal TASA_SFS = 0.0304m;

        // Entrada de datos.
        Console.Write("Ingresa el nombre del empleado: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingresa las horas trabajadas: ");
        decimal horasTrabajadas = Convert.ToDecimal(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        Console.Write("Ingresa el pago por hora: ");
        decimal pagoPorHora = Convert.ToDecimal(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        // Proceso: salario bruto, descuentos y salario neto.
        decimal salarioBruto = horasTrabajadas * pagoPorHora;
        decimal descuentoAfp = salarioBruto * TASA_AFP;
        decimal descuentoSfs = salarioBruto * TASA_SFS;
        decimal salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

        // Salida con nombre en mayusculas y montos con dos decimales.
        Console.WriteLine();
        Console.WriteLine("NOMINA DEL EMPLEADO");
        Console.WriteLine($"Nombre: {nombre.ToUpper()}");
        Console.WriteLine($"Salario bruto: RD${salarioBruto:N2}");
        Console.WriteLine($"AFP (2.87%): RD${descuentoAfp:N2}");
        Console.WriteLine($"SFS (3.04%): RD${descuentoSfs:N2}");
        Console.WriteLine($"Salario neto: RD${salarioNeto:N2}");
    }
}