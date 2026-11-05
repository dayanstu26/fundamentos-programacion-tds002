int productos = 0;
decimal subtotal = 0;
decimal precio;

// Se piden precios hasta que el usuario escriba 0
do
{
    Console.Write("Precio del producto (0 para terminar): ");

    if (!decimal.TryParse(Console.ReadLine(), out precio) || precio < 0)
    {
        Console.WriteLine("Precio inválido, intenta de nuevo.");
        precio = -1; // para que el ciclo siga
    }
    else if (precio > 0)
    {
        productos++;      // contador de productos
        subtotal += precio; // acumulador del subtotal
    }
} while (precio != 0);

// Cálculo del ITBIS (18 %) y el total
decimal itbis = subtotal * 0.18m;
decimal total = subtotal + itbis;

Console.WriteLine("\n--- FACTURA ---");
Console.WriteLine($"Productos: {productos}");
Console.WriteLine($"Subtotal: {subtotal:N2}");
Console.WriteLine($"ITBIS (18%): {itbis:N2}");
Console.WriteLine($"Total: {total:N2}");