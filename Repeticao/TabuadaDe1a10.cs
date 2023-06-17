/*
    Faça um programa que imprima as tabuadas dos números de 1 a 10.
*/

using System;

for (int numero = 1; numero <= 10; numero++)
{
    Console.WriteLine($"Tabuada do {numero}:");
    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int resultado = numero * multiplicador;
        Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
    }
    Console.WriteLine();
}