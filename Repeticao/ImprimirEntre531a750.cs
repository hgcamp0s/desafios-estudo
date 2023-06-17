/*
    Faça um programa que imprima os números impares no intervalo de 531 a 750.
*/

using System;

for (int count = 531; count <= 750; count++)
{
    if (count % 2 != 0)
    {
        Console.WriteLine($"{count}");
    }
}