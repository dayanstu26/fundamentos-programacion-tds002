int opcion;

// Menú principal: se repite hasta que el usuario elija 0
do
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1. Tablas");
    Console.WriteLine("2. Triángulo");
    Console.WriteLine("0. Salir");
    Console.Write("Elige una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = -1; // entrada no numérica: cae en default
    }

    switch (opcion)
    {
        case 1:
            MostrarTablas();
            break;
        case 2:
            DibujarTriangulo();
            break;
        case 0:
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (opcion != 0);

// Tablas del 1 al 10 con ciclos anidados, columnas alineadas
static void MostrarTablas()
{
    Console.WriteLine();

    for (int fila = 1; fila <= 10; fila++)
    {
        for (int columna = 1; columna <= 10; columna++)
        {
            Console.Write($"{fila * columna,4}");
        }
        Console.WriteLine();
    }
}

// Triángulo de asteriscos de N filas
static void DibujarTriangulo()
{
    int n;

    do
    {
        Console.Write("Número de filas: ");
    } while (!int.TryParse(Console.ReadLine(), out n) || n < 1);

    Console.WriteLine();

    for (int fila = 1; fila <= n; fila++)
    {
        for (int i = 1; i <= fila; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}