using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const decimal TASA_ITBIS = 0.18m;

        // Entrada: producto, cantidad y precio por unidad.
        Console.Write("Ingresa el nombre del producto: ");
        string producto = Console.ReadLine() ?? "";

        Console.Write("Ingresa la cantidad de unidades: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el precio por unidad: ");
        decimal precioUnitario = Convert.ToDecimal(
            Console.ReadLine(), CultureInfo.InvariantCulture
        );

        // Calculamos el subtotal, el impuesto y el total.
        decimal subtotal = cantidad * precioUnitario;
        decimal itbis = subtotal * TASA_ITBIS;
        decimal total = subtotal + itbis;

        // Alineamos el texto a la izquierda y los numeros a la derecha.
        Console.WriteLine();
        Console.WriteLine("FACTURA - MONTOS EN RD$");
        Console.WriteLine($"{"Producto",-24}{"Cantidad",10}{"Precio",14}{"Subtotal",14}");
        Console.WriteLine($"{producto,-24}{cantidad,10}{precioUnitario,14:N2}{subtotal,14:N2}");
        Console.WriteLine();
        Console.WriteLine($"{"Subtotal:",-24}{subtotal,14:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-24}{itbis,14:N2}");
        Console.WriteLine($"{"Total:",-24}{total,14:N2}");
    }
}