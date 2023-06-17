/*
    Faça um programa que leia um número da entrada(x) e imprima os (x) primeiros números pares
*/

using System;

Console.WriteLine("Digite um número:");
int x = int.Parse(Console.ReadLine());

for (int i = 2, count = 0; count < x; i += 2, count++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}