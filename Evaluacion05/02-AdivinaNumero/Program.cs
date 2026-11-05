// El programa guarda un número secreto entre 1 y 100
int secreto = Random.Shared.Next(1, 101);
int intentos = 0; // contador de intentos
bool acertado = false;

while (!acertado)
{
    Console.Write("Adivina el número (1-100): ");

    // Si no escribe un número válido, no cuenta como intento
    if (!int.TryParse(Console.ReadLine(), out int numero))
    {
        Console.WriteLine("Escribe un número válido.");
        continue;
    }

    intentos++;

    if (numero == secreto)
    {
        acertado = true;
    }
    else if (numero < secreto)
    {
        Console.WriteLine("Mayor");
    }
    else
    {
        Console.WriteLine("Menor");
    }
}

Console.WriteLine($"\n¡Correcto! El número era {secreto}.");
Console.WriteLine($"Intentos: {intentos}");