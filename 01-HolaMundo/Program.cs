/*
Nombre: Dayan Reyes
Fecha: 12/09/2026
Descripción: Muestra una tarjeta de presentación con un marco.
*/

using System;

// Configura la consola para mostrar las tildes.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Define el ancho interior de la tarjeta.
int ancho = 58;
string borde = new string('=', ancho + 2);

// Imprime el encabezado de la tarjeta.
Console.WriteLine(borde);
Console.WriteLine("|" + "TARJETA DE PRESENTACIÓN".PadLeft(40).PadRight(ancho) + "|");
Console.WriteLine(borde);

// Muestra los datos con espacios para alinear el borde derecho.
Console.WriteLine("|" + " Nombre: Dayan Reyes".PadRight(ancho) + "|");
Console.WriteLine("|" + " Matrícula: 2026-1515".PadRight(ancho) + "|");
Console.WriteLine("|" + " Carrera: Desarrollo de Software".PadRight(ancho) + "|");

// Muestra la frase personal y cierra el marco.
Console.WriteLine("|" + " Frase: Soy curioso y me gusta aprender cosas nuevas.".PadRight(ancho) + "|");
Console.WriteLine(borde);