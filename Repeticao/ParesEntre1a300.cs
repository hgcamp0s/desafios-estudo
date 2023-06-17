/*
    Faça um programa que imprima os números pares no intervalo de 1 a 300.
*/

using System;

for (int count = 1; count <= 300; count++)
{
    if (count % 2 == 0)
    {
        Console.WriteLine($"{count}");
    }
}