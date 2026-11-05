int cantidad = 0;
double suma = 0;      // acumulador
double mayor = 0;
double menor = 100;
double nota;

// Ciclo principal: termina cuando se escribe -1
do
{
    bool valida;

    // Validación con do-while: repite hasta que sea una nota de 0 a 100 o -1
    do
    {
        Console.Write("Nota (0-100, -1 para terminar): ");
        valida = double.TryParse(Console.ReadLine(), out nota)
                 && (nota == -1 || (nota >= 0 && nota <= 100));

        if (!valida)
        {
            Console.WriteLine("Nota inválida, intenta de nuevo.");
        }
    } while (!valida);

    if (nota != -1)
    {
        cantidad++;
        suma += nota;

        if (nota > mayor) mayor = nota;
        if (nota < menor) menor = nota;
    }
} while (nota != -1);

Console.WriteLine("\n--- RESULTADOS ---");

if (cantidad == 0)
{
    Console.WriteLine("No se ingresaron notas.");
}
else
{
    double promedio = suma / cantidad;
    Console.WriteLine($"Promedio: {promedio:N2}");
    Console.WriteLine($"Nota mayor: {mayor:N2}");
    Console.WriteLine($"Nota menor: {menor:N2}");
}