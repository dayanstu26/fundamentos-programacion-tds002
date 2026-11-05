int numero;
bool valido;

// 1. Pedir el número y validarlo con do-while
do
{
    Console.Write("Ingresa un número entre 1 y 12: ");
    valido = int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 12;

    if (!valido)
    {
        Console.WriteLine("Número inválido, intenta de nuevo.");
    }
} while (!valido);

// 2. Tabla de multiplicar del 1 al 12 con while
int contador = 1;
int suma = 0;

Console.WriteLine($"\nTabla del {numero}:");

while (contador <= 12)
{
    int resultado = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {resultado}");

    suma += resultado; // acumulador
    contador++;
}

// 3. Suma de todos los resultados
Console.WriteLine($"\nLa suma de todos los resultados es: {suma}");